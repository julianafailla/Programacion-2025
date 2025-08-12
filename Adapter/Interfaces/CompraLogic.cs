using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clases.Tipos;

namespace Interfaces
{
    public class CompraLogic : ICompra
    {
        public virtual List<Producto> GetProductos()
        {
            return new List<Producto>
                {
                    new Producto
                    {
                        codCompra = 1,
                        precio = 100.0f,
                        indumentarias = new List<Indumentaria>
                        {
                            new Indumentaria { id = 1, talle = "M", color = "Rojo" },
                            new Indumentaria { id = 2, talle = "L", color = "Azul" }
                        },
                        librerias = new List<Libreria>
                        {
                            new Libreria { id = 1, tipo = new Tipos { id = (int)TiposEnum.Infantil, descripcion = "Infantil" }, tamanio = "Grande" },
                            new Libreria { id = 2, tipo = new Tipos { id = (int)TiposEnum.NoFiccion, descripcion = "No Ficción" }, tamanio = "Mediano" }
                        }
                    }
                };

        }
    }
}


