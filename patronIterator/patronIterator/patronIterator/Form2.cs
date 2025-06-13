using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patronIterator
{
    public partial class Form2 : Form
    {
        private Mensaje iterador;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var mensaje = iterador.Next();
            MessageBox.Show(mensaje.mensaje);
        }

        private void buttonPrior_Click(object sender, EventArgs e)
        {
            var mensaje = iterador.Prior();
            MessageBox.Show(mensaje.mensaje);
        }

        private void buttonGoFirst_Click(object sender, EventArgs e)
        {
             iterador.GoFirst();
        }

        private void buttonGoLast_Click(object sender, EventArgs e)
        {
            iterador.GoLast();

        }

        private void buttonVerNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text.Trim();
            iterador = new Mensaje(usuario, string.Empty);  
            iterador.setIteraObj(Mensaje.BaseMensajes, usuario);
        }
    }
}
