namespace CENDI_admin.Clases.Utils
{
    internal class Edad
    {
        public int Año { get; set; } = 0;
        public int Mes { get; set; } = 0;

        public Edad(int edad_contada, int mes_contado)
        {
            Año = edad_contada;
            Mes = mes_contado;
        }
        public Edad() { }

    }
}
