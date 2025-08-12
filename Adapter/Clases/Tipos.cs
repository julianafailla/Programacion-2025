using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tipos
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public ICollection<Libreria> librerias { get; set; }

        public enum TiposEnum
        {
            Ficcion,
            NoFiccion,
            Infantil,
            Juvenil,
            CienciaFiccion,
            Fantasia,
            Historia,
            Biografia
        }
    }
}
