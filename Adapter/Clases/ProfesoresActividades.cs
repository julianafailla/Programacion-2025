using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProfesoresActividades
    {
        public int idProfesor { get; set; }
        public Profesor profesor { get; set; }
        public int idActividad { get; set; }
        public Actividad actividad { get; set; }
        public float costo { get; set; }
    }
}
