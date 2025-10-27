using MVP_Restaurante_EF.Interfaces;
using MVP_Restaurante_EF.Models;
using MVP_Restaurante_EF.Repository;
using MVP_Restaurante_EF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Restaurante_EF.Presenters
{
    public class ReservasPresenter
    {
        private readonly IReservasView _view;
        private readonly ReservasRepository _repository;
        private List<ClienteDTO> _clientesCache;

        // Constructor que inicializa la Vista y el Repositorio (usando instanciación por defecto del contexto)
        public ReservasPresenter(IReservasView view)
        {
            _view = view;
            // La compatibilidad es asegurada aquí: el Presenter crea el Contexto 
            // y lo pasa al constructor del Repositorio.
            _repository = new ReservasRepository(new RestauranteReservasEntities());
        }

        public ReservasPresenter(ReservasViews reservasViews)
        {
        }

        public void InicializarVista()
        {
            CargarCombos();
            CargarReservasActivas();
        }

        // --- Métodos llamados por el Presenter para actualizar la Vista ---
        private void CargarCombos()
        {
            try
            {
                _clientesCache = _repository.GetClientesActivos();
                var mesas = _repository.GetMesasActivas();

                _view.MostrarClientes(_clientesCache);
                _view.MostrarMesas(mesas);
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al cargar datos iniciales: {ex.Message}");
            }
        }

        public void CargarReservasActivas()
        {
            try
            {
                var reservas = _repository.GetReservasActivasHoy();
                _view.MostrarReservasActivas(reservas);
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al cargar reservas activas: {ex.Message}");
            }
        }

        // --- Métodos que responden a Eventos de la Vista (ConfirmarReservaClicked) ---

        public void ConfirmarNuevaReserva(NuevaReservaDTO data)
        {
            // Validación básica de campos necesarios antes de ir a la DB
            if (data.ClienteId <= 0 || data.MesaId <= 0 || data.DuracionHoras <= 0)
            {
                _view.MostrarError("Debe seleccionar un cliente, una mesa y una duración válida.");
                return;
            }

            // Obtener datos del cliente del caché para usar GrupoPorDefecto si es necesario
            var clienteInfo = _clientesCache.FirstOrDefault(c => c.ClienteId == data.ClienteId);
            if (clienteInfo == null)
            {
                _view.MostrarError("Cliente no encontrado o no activo.");
                return;
            }

            try
            {
                // Llama al método del Repositorio para insertar
                _repository.InsertarNuevaReserva(data, clienteInfo);

                _view.MostrarMensajeExito("Reserva confirmada y guardada en la base de datos.");
                _view.LimpiarFormularioNuevaReserva();
                CargarReservasActivas(); // Refrescar el panel derecho
            }
            catch (Exception ex)
            {
                // Manejo de errores de base de datos
                _view.MostrarError($"Error de base de datos al guardar: {ex.Message}");
            }
        }

        public void CancelarReservaActiva(int reservaId)
        {
            try
            {
                // Llama al método del Repositorio para actualizar el estado
                _repository.ActualizarEstadoReserva(reservaId, "Cancelada");

                _view.MostrarMensajeExito($"Reserva {reservaId} cancelada con éxito.");
                CargarReservasActivas();
            }
            catch (Exception ex)
            {
                _view.MostrarError($"Error al cancelar la reserva: {ex.Message}");
            }
        }
    }
    public class TarjetaActiva 
    {
        
            // Campo privado para la referencia al Presenter principal.
            private readonly IReservaPresenter _presenter;

            // Aquí deberías tener los controles visuales internos (ej. LabelFecha, ButtonCancelar).
            // private Label labelFecha;
            // private Button buttonCancelar;

            // Constructor que recibe el Presenter (igual que tu código original).
            public TarjetaActiva(IReservaPresenter presenter)
            {
                _presenter = presenter;

                // Aquí se inicializan los controles visuales internos (si este es un control compuesto).
                // InitializeComponent(); 
            }

            // Propiedad/Campo para almacenar la ReservaActivaDTO que se va a mostrar.
            private ReservaActivaDTO _datosReserva;

            // Método para pasar los datos a la tarjeta.
            public void SetData(ReservaActivaDTO reserva)
            {
                _datosReserva = reserva;

                // Lógica para mostrar los datos en los controles UI internos.
                
            }

            // Evento que tu Presenter original estaba suscribiendo.
            // Esto se mantiene para compatibilidad con el Presenter que lo instancia.
            public event EventHandler<int> CancelarClicked;

            
            private void OnCancelarClickedInterno(object sender, EventArgs e)
            {
                
                CancelarClicked?.Invoke(this, _datosReserva.ReservaId);
            }
        
    }
}
