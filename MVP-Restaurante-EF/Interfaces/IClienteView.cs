using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Restaurante_EF.Interfaces
{
    public interface IClienteView
    {
        // Propiedades para los campos del formulario
        int? ClienteId { get; set; }
        string NombreCompleto { get; set; } // Ajustado a tu DB
        string Telefono { get; set; }
        string Correo { get; set; } // Ajustado a tu DB
        byte GrupoPorDefecto { get; set; } // Ajustado a tu DB (era N° Personas)
        bool Activo { get; set; } // Añadido desde tu DB

        // Propiedad para enlazar los datos al DataGridView
        object DataSource { get; set; }

        // Eventos que la Vista disparará
        event EventHandler CargarClientesEvent;
        event EventHandler GuardarClienteEvent; // Un solo evento para Guardar (Nuevo o Editar)
        event EventHandler EliminarClienteEvent; // (Será un Soft Delete)

        // Evento CLAVE para notificar a otros formularios (Reservas)
        event EventHandler ListaDeClientesCambioEvent;

        // Métodos para interactuar con la vista
        void MostrarMensaje(string mensaje, string titulo);
        void LimpiarFormulario();
        void SetModoEdicion(bool enEdicion);
    }
    
}
