using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libreria 
    {
        public int id { get; set; } 
        public Tipos tipo { get; set; }
        public string tamanio { get; set; }
        public Producto producto { get; set; }
    }
}
