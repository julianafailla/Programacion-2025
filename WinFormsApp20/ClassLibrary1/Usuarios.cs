namespace ClassLibrary1
{
    public class Usuarios : Clientes
    {
      
        public string clave {  get; set; }
        // Instancia única (Singleton)
        private static Usuarios instancia;


        // Método para acceder a la instancia única
        public static Usuarios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Usuarios();
                }
                return instancia;
            }
        }


        // Método para setear los datos del usuario cuando se loguea
        public static void Login(Usuarios usuario)
        {
            instancia = usuario;
        }

        // Método para cerrar sesión (opcional)
        public static void Logout()
        {
            instancia = null;
        }
    }
}
