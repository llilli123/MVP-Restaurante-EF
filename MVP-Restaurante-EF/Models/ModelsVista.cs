using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Restaurante_EF.Models
{
    public class ClienteDTO
    {
        public int ClienteId { get; set; }
        public string NombreCompleto { get; set; }
        public byte GrupoPorDefecto { get; set; } // Lo usaremos si el campo NumeroPersonas falta en la UI
    }

    // DTO para llenar el combo de Mesas
    public class MesaDTO
    {
        public int MesaId { get; set; }
        public int NumeroMesa { get; set; }
    }

    // DTO para los datos recogidos de la UI de "Nueva Reserva"
    public class NuevaReservaDTO
    {
        // Datos necesarios para el INSERT
        public int ClienteId { get; set; }
        public int MesaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } // Recogida como string "HH:mm"
        public byte DuracionHoras { get; set; }
        public byte NumeroPersonas { get; set; } // ¡Importante! Debe ser obtenido de alguna manera
    }

    // DTO para mostrar en las "Tarjetas de Reservas Activas"
    public class ReservaActivaDTO
    {
        public int ReservaId { get; set; }
        public string Cliente { get; set; }
        public int Mesa { get; set; }
        public byte NumeroPersonas { get; set; }
        public string Fecha { get; set; } // Lo mostramos como string (ej: "26/10/2025")
        public string Hora { get; set; } // Lo mostramos como string (ej: "19:00")
        public byte DuracionHoras { get; set; }
    }

}
