using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public ICollection<Profesor> profesores { get; set; } = new List<Profesor>();
        public ICollection<Socios> socios { get; set; } = new List<Socios>();
    }
}
