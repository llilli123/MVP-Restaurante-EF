using System;
using System.Collections.Generic;
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
            // IMPORTANTE: Solo mostrar clientes activos
            return _context.clientes.Where(c => c.Activo == true).ToList();
        }

        public void Add(cliente cliente)
        {
            cliente.Activo = true; // Por defecto, un nuevo cliente está activo
            _context.clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Update(cliente cliente)
        {
            // El 'cliente' que viene de la vista ya tiene todos los datos (incluyendo el ID)
            var clienteExistente = _context.clientes.Find(cliente.ClienteId);
            if (clienteExistente != null)
            {
                _context.Entry(clienteExistente).CurrentValues.SetValues(cliente);
                _context.SaveChanges();
            }
        }

        // IMPLEMENTACIÓN DE SOFT DELETE
        public void Delete(int clienteId)
        {
            var cliente = _context.clientes.Find(clienteId);
            if (cliente != null)
            {
                cliente.Activo = false; // En lugar de removerlo, lo marcamos como inactivo
                _context.SaveChanges();
            }
        }
    }
} 

