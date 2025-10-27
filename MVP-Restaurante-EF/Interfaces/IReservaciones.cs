using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Restaurante_EF.Interfaces
{
    public interface IReservaciones
    {
        void MostrarReservas(object data);
        void MostrarMensajeDeError(string mensaje);

    }
}
