using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public int codCompra { get; set; }
        public float precio { get; set; }
        public ICollection<Indumentaria> indumentarias { get; set; }
        public ICollection<Libreria> librerias { get; set; }
    }

}
