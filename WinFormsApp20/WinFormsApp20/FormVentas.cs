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

namespace WinFormsApp20
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            this.Text = $"Menú Principal - {Usuarios.Instancia.nombre}";

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
