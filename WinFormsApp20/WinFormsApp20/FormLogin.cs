using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20
{
    public partial class FormLogin : Form
    {
        public Usuarios usuLoggeado;
        public List<Usuarios> ListaUsu = new List<Usuarios>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // busco mi base de usuario.
            string json = File.ReadAllText("usuarios.txt");

            ListaUsu = JsonSerializer.Deserialize<List<Usuarios>>(json);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // a ver si pusieron bien la clave.
            Usuarios usuarioEncontrado = ListaUsu.Find(u => u.nombre == textBox1.Text
                && u.clave == textBox2.Text);

            if (usuarioEncontrado != null)
            {
                Usuarios.Login(usuarioEncontrado); // Copia los datos al Singleton
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                usuLoggeado = null;
                MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Text = $"Menú Principal - {Usuarios.Instancia.nombre}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
