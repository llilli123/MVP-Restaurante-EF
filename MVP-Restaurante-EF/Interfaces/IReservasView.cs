using MVP_Restaurante_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Restaurante_EF.Interfaces
{
    public interface IReservasView
    {
        // Métodos para cargar los combos
        void MostrarClientes(List<ClienteDTO> clientes);
        void MostrarMesas(List<MesaDTO> mesas);

        // Métodos para cargar el panel derecho
        void MostrarReservasActivas(List<ReservaActivaDTO> reservas);

        // Métodos para retroalimentación
        void MostrarMensajeExito(string mensaje);
        void MostrarError(string mensaje);
        void LimpiarFormularioNuevaReserva();
    }
    public interface IReservaPresenter
    {
      void SetData();
    }
}
