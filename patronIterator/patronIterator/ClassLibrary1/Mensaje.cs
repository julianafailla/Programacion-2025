using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Mensaje : IIterator<Mensaje>
    {
        public string usuario { get; set; }
        public string mensaje { get; set; }

        public Mensaje(string usuario, string mensaje)
        {
            this.usuario = usuario;
            this.mensaje = mensaje;
        }

        public static List<Mensaje> BaseMensajes { get; set; }

        public static List<Mensaje> dameListaEjemplo()
        {
            BaseMensajes.Add(new Mensaje("Matias", "Acordate de pagar la patente"));
            BaseMensajes.Add(new Mensaje("Pedro", "Ir a vistiar a los parientes"));
            BaseMensajes.Add(new Mensaje("Ernesto", "apagá el agua"));
            BaseMensajes.Add(new Mensaje("Pedro", "pedite licencia "));
            BaseMensajes.Add(new Mensaje("Matias", "anda al cajero"));
            BaseMensajes.Add(new Mensaje("Matias", "busca el pan de la panaderia"));
            return BaseMensajes;
        }

        private List<Mensaje> mensajesFiltrados;
        private int indice;

        public void setIteraObj(List<Mensaje> mensajes, string usuario)
        {
            mensajesFiltrados = mensajes.Where(m => m.usuario == usuario).ToList();
            indice = 0;
        }

        public void GoFirst()
        {
            indice = 0;
        }

        public void GoLast()
        {
            if (mensajesFiltrados != null && mensajesFiltrados.Count > 0)
            {
                indice = mensajesFiltrados.Count - 1;
            }
        }

        public bool HasNext()
        {
            return mensajesFiltrados != null && indice < mensajesFiltrados.Count;
        }

        public bool HasPrior()
        {
            return mensajesFiltrados != null && indice > 0 && mensajesFiltrados.Count > 0;
        }

        public Mensaje Next()
        {
            if (HasNext())
            {
                Mensaje aDevolver = mensajesFiltrados[indice];
                indice++;
                return aDevolver;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public Mensaje Prior()
        {
            if (HasPrior())
            {
                indice--;
                Mensaje elReturn = Next();
                indice--;
                return elReturn;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}