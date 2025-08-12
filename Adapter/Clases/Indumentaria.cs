using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Indumentaria 
    {
        public int id { get; set; }
        public string talle { get; set; }
        public string color { get; set; }
        public Producto producto { get; set; } 
    }
}
