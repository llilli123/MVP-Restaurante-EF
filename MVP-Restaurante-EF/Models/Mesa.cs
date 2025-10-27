using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Restaurante_EF.Models
{
    public class Mesa
    {
        public int Id { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
    }
}
