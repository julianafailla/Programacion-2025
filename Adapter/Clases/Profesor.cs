using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Profesor 
    {
        public int id { get; set; }
        public string legajo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Persona persona { get; set; }

    }
}
