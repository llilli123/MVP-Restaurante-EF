using System;
using System.Text.RegularExpressions;
using MVP_Restaurante_EF.Interfaces; // Para IClienteView
using MVP_Restaurante_EF.Repositories; // Para ClienteRepository
using MVP_Restaurante_EF; // Para la clase Cliente

namespace MVP_Restaurante_EF.Presenters
{
    public class ClientePresenter
    {
        private readonly IClienteView _view;
        private readonly ClienteRepository _repository;

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
                    _repository.Delete(_view.ClienteId.Value);
                    _view.MostrarMensaje("Cliente eliminado con éxito.", "Éxito");
                    CargarClientes(null, null); // Recargar la lista
                    DispararEventoListaCambiada(); // Notificar a otros forms
                }
                else
                {
                    _view.MostrarMensaje("No se ha seleccionado ningún cliente para eliminar.", "Aviso");
                }
            }
            catch (Exception ex)
            {
                _view.MostrarMensaje($"Error al eliminar: {ex.Message}", "Error");
                // Aquí NO limpiamos el context, porque un 'Delete' fallido
                // (ej. por una FK_Reserva) es un error de BD válido, no un 'envenenamiento'.
            }
        }

        private void GuardarCliente(object sender, EventArgs e)
        {
            // 1. Realizar Validaciones de la UI
            if (!ValidarDatos())
            {
                return; // Si la validación falla, no continuamos
            }

            try
            {
                // 2. Revisar si el correo ya existe
                var clienteExistente = _repository.GetByEmail(_view.Correo);

                if (_view.ClienteId.HasValue && _view.ClienteId != 0)
                {
                    // --- MODO EDICIÓN ---

                    // Revisa si el correo se cambió a uno que YA existe en OTRO cliente
                    if (clienteExistente != null && clienteExistente.ClienteId != _view.ClienteId.Value)
                    {
                        _view.MostrarMensaje($"El correo '{_view.Correo}' ya está en uso por otro cliente.", "Validación");
                        return;
                    }

                    // Obtiene el cliente de la BD y actualiza sus datos
                    var clienteAActualizar = _repository.GetById(_view.ClienteId.Value);
                    if (clienteAActualizar != null)
                    {
                        clienteAActualizar.NombreCompleto = _view.NombreCompleto;
                        clienteAActualizar.Telefono = _view.Telefono;
                        clienteAActualizar.Correo = _view.Correo;
                        clienteAActualizar.GrupoPorDefecto = _view.GrupoPorDefecto;
                        clienteAActualizar.Activo = _view.Activo;

                        _repository.Update(clienteAActualizar);
                        _view.MostrarMensaje("Cliente actualizado con éxito.", "Éxito");
                    }
                }
                else
                {
                    // --- MODO NUEVO ---

                    if (clienteExistente != null)
                    {
                        // El cliente existe. ¿Está inactivo?
                        if (!clienteExistente.Activo)
                        {
                            // ¡Reactívalo!
                            clienteExistente.NombreCompleto = _view.NombreCompleto;
                            clienteExistente.Telefono = _view.Telefono;
                            clienteExistente.GrupoPorDefecto = _view.GrupoPorDefecto;
                            clienteExistente.Activo = true; // Reactivación

                            _repository.Update(clienteExistente);
                            _view.MostrarMensaje("Cliente reactivado y actualizado con éxito.", "Éxito");
                        }
                        else
                        {
                            // El cliente existe Y está activo
                            _view.MostrarMensaje($"El correo '{_view.Correo}' ya está registrado y activo.", "Validación");
                            return; // Detiene la operación
                        }
                    }
                    else
                    {
                        // Es un cliente 100% nuevo
                        var clienteNuevo = new cliente
                        {
                            NombreCompleto = _view.NombreCompleto,
                            Telefono = _view.Telefono,
                            Correo = _view.Correo,
                            GrupoPorDefecto = _view.GrupoPorDefecto,
                            Activo = _view.Activo // El repo se asegura de ponerlo en true
                        };
                        _repository.Add(clienteNuevo);
                        _view.MostrarMensaje("Cliente agregado con éxito.", "Éxito");
                    }
                }

                // 3. Si todo salió bien, limpiar y recargar
                _view.LimpiarFormulario();
                CargarClientes(null, null); // Recargar la lista
                DispararEventoListaCambiada(); // Notificar a otros forms
            }
            catch (Exception ex)
            {
                // ¡Error! "Envenenamiento" del Context
                _view.MostrarMensaje($"Error al guardar: {ex.Message}\n\n{ex.InnerException?.Message}", "Error");
                // Limpia el context para evitar errores en cadena
                _repository.LimpiarCambiosFallidos();
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

            // Validación de Teléfono (ej: 10 dígitos)
            if (string.IsNullOrWhiteSpace(_view.Telefono) || !Regex.IsMatch(_view.Telefono, @"^\d{10}$"))
            {
                _view.MostrarMensaje("El formato del teléfono no es válido (Debe tener 10 dígitos, sin guiones).", "Validación");
                return false;
            }

            // Validación de Email (regex)
            if (!string.IsNullOrWhiteSpace(_view.Correo)) // Permite correo vacío
            {
                try
                {
                    // Una validación de email más robusta
                    var addr = new System.Net.Mail.MailAddress(_view.Correo);
                    if (addr.Address != _view.Correo)
                    {
                        _view.MostrarMensaje("El formato del correo no es válido.", "Validación");
                        return false;
                    }
                }
                catch
                {
                    _view.MostrarMensaje("El formato del correo no es válido.", "Validación");
                    return false;
                }
            }
            else
            {
                _view.MostrarMensaje("El correo es obligatorio.", "Validación");
                return false;
            }


            // Validación GrupoPorDefecto
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
            //_view.ListaDeClientesCambiadaEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}