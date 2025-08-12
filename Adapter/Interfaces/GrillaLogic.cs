using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class GrillaLogic : IGrilla
    {
        public virtual List<Persona> GetPersonas()
        {
            return new List<Persona>
            {
                new Persona
                {
                    id = 1,
                    nombre = "Ana García",
                    dni = "12345678",
                    direccion = "Calle Falsa 123",
                    profesores = new List<Profesor>(),
                    socios = null
                },
                new Persona
                {
                    id = 2,
                    nombre = "Luis Pérez",
                    dni = "87654321",
                    direccion = "Avenida Siempre Viva 456",
                    profesores = null,
                    socios = new List<Socios>()
                }
            };
        }
    }
}
