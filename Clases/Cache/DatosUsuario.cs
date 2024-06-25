namespace CENDI_admin.Clases.Cache
{
    static class DatosUsuario
    {
        [Flags]
        public enum Tipo
        {
            None = 0,
            Admin = 1,
            Usuario = 2
        }

        public static int NoEmpleado {  get; set; }
        public static string? Contraseña { get; set; }
        public static int TipoUsuario { get; set; }

    }
}
