using System;
using System.Linq;
using System.Windows.Forms;
using MVP_Restaurante_EF.Views;
using MVP_Restaurante_EF.Interfaces;

namespace MVP_Restaurante_EF.Presenters
{
    public class ReservacionesPresenter
    {
        // Referencia a la capa de datos (Contexto de Entity Framework)
        private RestauranteReservasEntities _context = new RestauranteReservasEntities();



        // Referencia a la vista a través de la interfaz
        private readonly IReservaciones _view;

        public ReservacionesPresenter(IReservaciones view)
        {
            _view = view;
        }


        /// Consulta las reservas y notifica a la vista para que las muestre.
        public void CargarReservas()
        {
            try
            {
                // Consultar las reservas y proyectar solo la información relevante
                var reservas = _context.reservas
                    .Select(r => new
                    {
                        r.ReservaId,
                        Cliente = r.ClienteId, 
                        Mesa = r.MesaId, 
                        r.Fecha,
                        r.HoraInicio,
                        r.DuracionHoras,
                        r.NumeroPersonas,
                        r.Estado
                    })
                    .ToList();

                // Llamar al método de la vista para mostrar los datos
                
            }
            catch (Exception ex)
            {
                // Llamar al método de la vista para mostrar el error
                _view.MostrarMensajeDeError("Error al cargar las reservas: " + ex.Message);
            }
        }

    }
}
