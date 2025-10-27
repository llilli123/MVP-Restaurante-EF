using System;
using System.Collections.Generic;
using System.Data.Entity; // Para gestionar el estado de la entidad (EntityState)
using System.Data.Entity.Infrastructure; // Para acceder a las entradas del ChangeTracker
using System.Linq;
using MVP_Restaurante_EF;

namespace MVP_Restaurante_EF.Repositories
{
    public class ClienteRepository
    {
        private readonly RestauranteReservasEntities _context;

        public ClienteRepository(RestauranteReservasEntities context)
        {
            _context = context;
        }

        public List<cliente> GetAll()
        {
            // Asegura que solo trae los activos para la lista principal
            return _context.clientes.Where(c => c.Activo == true).ToList();
        }

        public cliente GetByEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return null;
            // Busca en toda la tabla, sin importar si está activo o no, para validaciones de duplicados
            return _context.clientes.FirstOrDefault(c => c.Correo.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public cliente GetById(int clienteId)
        {
            return _context.clientes.Find(clienteId);
        }

        public void Add(cliente cliente)
        {
            cliente.Activo = true; // Asegura que el nuevo cliente esté activo
            _context.clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Update(cliente cliente)
        {
            // Marca la entidad completa como 'Modificada' para que EF la actualice en todos sus campos
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int clienteId)
        {
            var cliente = _context.clientes.Find(clienteId);
            if (cliente != null)
            {
                cliente.Activo = false; // Borrado lógico (marcar como inactivo)
                _context.SaveChanges();
            }
        }

        public void LimpiarCambiosFallidos()
        {
            // Obtiene todas las entidades que están marcadas para Agregar, Modificar o Borrar
            var entradasFallidas = _context.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted);

            // Revierte los cambios en memoria a su estado original (Unchanged)
            // Esto evita que EF intente guardar el cambio fallido la próxima vez.
            foreach (var entry in entradasFallidas.ToList())
            {
                entry.State = EntityState.Unchanged;
            }
        }
    }
}