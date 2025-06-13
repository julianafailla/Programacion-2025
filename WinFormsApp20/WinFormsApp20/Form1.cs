using ClassLibrary1;
using System.Text.Json;

namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Si el usuario aún NO se logueó, abrir el FormLogin
            if (Usuarios.Instancia == null || string.IsNullOrEmpty(Usuarios.Instancia.clave))
            {
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();

                if (formLogin.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this.Text = $"Menú Principal - {Usuarios.Instancia.nombre}";

            // Usuario ya logueado
            ABMClientes elForm = new ABMClientes();
            elForm.ShowDialog();
        }

        public void escribeBase()
        {
            // Lista de usuarios base
            var listaUsuarios = new List<Usuarios>
                {
                    new Usuarios { nombre = "Juan", id = 1, direccion = "por ahí", clave = "12345" },
                    new Usuarios { nombre = "Maria", id = 2, direccion = "por allá", clave = "abcde" }
                };

            string json = JsonSerializer.Serialize(listaUsuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("usuarios.txt", json);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Usuarios.Instancia == null || string.IsNullOrEmpty(Usuarios.Instancia.clave))
            {
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();

                if (formLogin.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            FormVentas elForm = new FormVentas();
            elForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Si el usuario aún NO se logueó, abrir el FormLogin
            if (Usuarios.Instancia == null || string.IsNullOrEmpty(Usuarios.Instancia.clave))
            {
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();

                if (formLogin.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            FormReportes elForm = new FormReportes();
            elForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar el sistema");
            this.Close();

        }
    }
}
