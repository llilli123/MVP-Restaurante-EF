using System;
using System.Text.RegularExpressions;
using MVP_Restaurante_EF; // Para la clase 'Cliente'
using MVP_Restaurante_EF.Interfaces; // Para 'IClienteView'
using MVP_Restaurante_EF.Repositories; // Para 'ClienteRepository'

namespace MVP_Restaurante_EF.Presenters // <-- Namespace para tus presentadores
{
    public class ClientePresenter
    {
        private readonly IClienteView _view;
        private readonly ClienteRepository _repository;

        // El constructor recibe las abstracciones (la interfaz y el repositorio)
        public ClientePresenter(IClienteView view, ClienteRepository repository)
        {
            _view = view;
            _repository = repository;

            // Suscripción a los eventos de la vista
            _view.CargarClientesEvent += CargarClientes;
            _view.GuardarClienteEvent += GuardarCliente;
            _view.EliminarClienteEvent += EliminarCliente;
        }

        private void CargarClientes(object sender, EventArgs e)
        {
            try
            {
                // El repositorio ya filtra solo los activos
                _view.DataSource = _repository.GetAll();
            }
            catch (Exception ex)
            {
                _view.MostrarMensaje($"Error al cargar clientes: {ex.Message}", "Error");
            }
        }

        private void EliminarCliente(object sender, EventArgs e)
        {
            try
            {
                if (_view.ClienteId.HasValue)
                {
                    _repository.Delete(_view.ClienteId.Value); // Borrado lógico
                    _view.MostrarMensaje("Cliente desactivado con éxito.", "Éxito");
                    CargarClientes(null, null); // Recargar la lista
                    DispararEventoListaCambiada(); // Notificar a otros forms
                }
                else
                {
                    _view.MostrarMensaje("Debe seleccionar un cliente para eliminar.", "Aviso");
                }
            }
            catch (Exception ex)
            {
                _view.MostrarMensaje($"Error al eliminar: {ex.Message}", "Error");
            }
        }

        private void GuardarCliente(object sender, EventArgs e)
        {
            // 1. Realizar Validaciones
            if (!ValidarDatos())
            {
                return; // Si la validación falla, no continuamos
            }

            // 2. Crear el objeto Cliente desde la vista
            var cliente = new cliente
            {
                ClienteId = _view.ClienteId ?? 0, // Si es null, es 0 (para nuevo)
                NombreCompleto = _view.NombreCompleto,
                Telefono = _view.Telefono,
                Correo = _view.Correo,
                GrupoPorDefecto = _view.GrupoPorDefecto,
                Activo = _view.Activo
            };

            try
            {
                if (_view.ClienteId.HasValue && _view.ClienteId != 0)
                {
                    // Es una edición
                    _repository.Update(cliente);
                    _view.MostrarMensaje("Cliente actualizado con éxito.", "Éxito");
                }
                else
                {
                    // Es un nuevo cliente
                    _repository.Add(cliente);
                    _view.MostrarMensaje("Cliente agregado con éxito.", "Éxito");
                }

                _view.LimpiarFormulario();
                _view.SetModoEdicion(false); // Regresar a modo "Agregar"
                CargarClientes(null, null);  // Recargar la lista
                DispararEventoListaCambiada(); // Notificar a otros forms
            }
            catch (Exception ex)
            {
                _view.MostrarMensaje($"Error al guardar: {ex.Message}", "Error");
            }
        }

        private bool ValidarDatos()
        {
            // Validación de Nombre
            if (string.IsNullOrWhiteSpace(_view.NombreCompleto))
            {
                _view.MostrarMensaje("El nombre es obligatorio.", "Validación");
                return false;
            }

            // Validación de Teléfono (formato: 10 dígitos)
            // Permite que sea nulo o vacío, pero si se escribe, debe ser válido
            if (!string.IsNullOrEmpty(_view.Telefono) && !Regex.IsMatch(_view.Telefono, @"^\d{10}$"))
            {
                _view.MostrarMensaje("El formato del teléfono no es válido (ej: 8091234567).", "Validación");
                return false;
            }

            // Validación de Email (regex)
            // Permite que sea nulo o vacío, pero si se escribe, debe ser válido
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!string.IsNullOrEmpty(_view.Correo) && !Regex.IsMatch(_view.Correo, emailPattern))
            {
                _view.MostrarMensaje("El formato del email no es válido.", "Validación");
                return false;
            }

            // Validación N° Personas (GrupoPorDefecto)
            if (_view.GrupoPorDefecto < 1 || _view.GrupoPorDefecto > 12)
            {
                _view.MostrarMensaje("El número de personas (grupo) debe estar entre 1 y 12.", "Validación");
                return false;
            }

            return true;
        }

        // Método para disparar el evento de notificación
        private void DispararEventoListaCambiada()
        {
            // Si alguien (como el form de Reservas) está escuchando, notifícale.
            //_view.ListaDeClientesCambioEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
