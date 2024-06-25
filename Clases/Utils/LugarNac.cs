namespace CENDI_admin.Clases.Utils
{
    internal class LugarNac
    {
        public DateTime FechaNac { get; set; }
        public int LugarNacimiento { get; set; }

        public LugarNac(DateTime fechaNac, int lugarNacimiento)
        {
            FechaNac = fechaNac;
            LugarNacimiento = lugarNacimiento;
        }

        public LugarNac() { }
    }
}
