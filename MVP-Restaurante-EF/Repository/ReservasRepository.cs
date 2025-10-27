using MVP_Restaurante_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MVP_Restaurante_EF.Repository
{
    public class ReservasRepository
    {
        // Usamos el contexto que se inyecta desde la capa superior (DI)
        private readonly RestauranteReservasEntities _context;

        public ReservasRepository(RestauranteReservasEntities context)
        {
            _context = context;
        }

        // -------------------------------------------------------------
        // MÉTODOS PARA CARGAR COMBOS (SELECT)
        // -------------------------------------------------------------

        // Método 1: Obtener clientes activos (Para el combo Cliente)
        public List<ClienteDTO> GetClientesActivos()
        {
            // Consulta LINQ: Filtra activos, ordena y proyecta a ClienteDTO
            return _context.clientes
                .Where(c => c.Activo)
                .OrderBy(c => c.NombreCompleto)
                .Select(c => new ClienteDTO
                {
                    ClienteId = c.ClienteId,
                    NombreCompleto = c.NombreCompleto,
                    GrupoPorDefecto = c.GrupoPorDefecto
                }).ToList();
        }

        // Método 2: Obtener mesas activas (Para el combo Mesa)
        public List<MesaDTO> GetMesasActivas()
        {
            // Consulta LINQ: Filtra activas, ordena por número de mesa y proyecta a MesaDTO
            return _context.mesas
                .Where(m => m.Activa)
                .OrderBy(m => m.NumeroMesa)
                .Select(m => new MesaDTO
                {
                    MesaId = m.MesaId,
                    NumeroMesa = m.NumeroMesa
                }).ToList();
        }

        // -------------------------------------------------------------
        // MÉTODOS PARA CARGAR EL PANEL DERECHO (RESERVAS ACTIVAS)
        // -------------------------------------------------------------

        // Método 3: Obtener reservas activas de hoy
        public List<ReservaActivaDTO> GetReservasActivasHoy()
        {
            DateTime today = DateTime.Today.Date;

            // Consulta LINQ: JOIN implícito (Include) y filtro por fecha y estado
            return _context.reservas
                .Include(r => r.cliente)
                .Include(r => r.mesa)
                .Where(r => r.Fecha == today && (r.Estado == "Pendiente" || r.Estado == "Confirmada"))
                .OrderBy(r => r.FechaHoraInicio)
                .Select(r => new ReservaActivaDTO
                {
                    ReservaId = r.ReservaId,
                    Cliente = r.cliente.NombreCompleto,
                    Mesa = r.mesa.NumeroMesa,
                    NumeroPersonas = r.NumeroPersonas,
                    Fecha = r.Fecha.ToString("dd/MM/yyyy"),
                    Hora = r.HoraInicio.ToString(@"hh\:mm"),
                    DuracionHoras = r.DuracionHoras
                }).ToList();
        }

        // -------------------------------------------------------------
        // MÉTODOS PARA MANEJO DE RESERVAS (INSERT/UPDATE)
        // -------------------------------------------------------------

        // Método 4: Insertar nueva reserva (ConfirmarReservaClicked)
        public void InsertarNuevaReserva(NuevaReservaDTO reservaData, ClienteDTO clienteInfo)
        {
            // Lógica de conversión de datos del DTO a la Entidad
            TimeSpan horaInicioTs = TimeSpan.Parse(reservaData.Hora);
            DateTime fechaHoraInicioDt = reservaData.Fecha.Date.Add(horaInicioTs);

            byte numeroPersonas = reservaData.NumeroPersonas > 0
                                  ? reservaData.NumeroPersonas
                                  : clienteInfo.GrupoPorDefecto;

            var nuevaReserva = new reserva
            {
                ClienteId = reservaData.ClienteId,
                MesaId = reservaData.MesaId,
                FechaHoraInicio = fechaHoraInicioDt,
                DuracionHoras = reservaData.DuracionHoras,
                Fecha = reservaData.Fecha.Date,
                HoraInicio = horaInicioTs,
                NumeroPersonas = numeroPersonas,
                Estado = "Confirmada"
            };

            _context.reservas.Add(nuevaReserva);
            _context.SaveChanges();
        }

        // Método 5: Actualizar estado de reserva (CancelarReservaClicked)
        public void ActualizarEstadoReserva(int reservaId, string nuevoEstado)
        {
            var reservaExistente = _context.reservas.Find(reservaId);

            if (reservaExistente != null)
            {
                reservaExistente.Estado = nuevoEstado;
                _context.SaveChanges();
            }
        }
    }
}
