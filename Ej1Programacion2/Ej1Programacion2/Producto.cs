using Ej1Programacion2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Practica2
{
    public class Producto
    {
        public TipoProducto TipoProducto { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public Tamanio Tamanio { get; set; }
        public int stock { get; set; }
    }
}
