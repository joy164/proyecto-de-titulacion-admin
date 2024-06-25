namespace CENDI_admin.Clases.Utils
{

    /// <summary>
    /// Clase auxiliar para los atributos de otras clases que tienen un nombre
    /// </summary>
    internal class Nombre
    {
        #region Atributos
        public string Nombres { get; set; } = "SIN NOMBRE";
        public string ApellidoPaterno { get; set; } = "SIN APELLIDO PATERNO";
        public string ApellidoMaterno { get; set; } = "SIN APELLIDO MATERNO";
        #endregion

        #region Constructor

        public Nombre(string nombres, string apellidoPaterno, string apellidoMaterno)
        {
            Nombres = nombres;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }
        public Nombre()
        {
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            return ToString();
        }

        /// <summary>
        /// Devuelve una cadena que represena el objeto actual
        /// </summary>
        /// <param name="fmt">Especifica en que forma queremos representar el nombre AP_NOM: empieza el nombre con apellidos, NOM_AP: empieza el nombre por sus nombres, NOM: solo los nombres, AP: solo los apellidos</param>
        /// <returns>Una cadena que represena el objeto actual</returns>
        /// <exception cref="ArgumentException">Sucede cuando el argumento no es valido</exception>
        public string ToString(string fmt = "AP_NOM")
        {
            switch (fmt.ToUpperInvariant())
            {
                case "AP_NOM":
                    return string.Format("{0} {1} {2}", ApellidoPaterno, ApellidoMaterno, Nombres);
                case "NOM_AP":
                    return string.Format("{0} {1} {2}", Nombres, ApellidoPaterno, ApellidoMaterno);
                case "NOM":
                    return string.Format("{0}", Nombres);
                case "AP":
                    return string.Format("{0} {1}", ApellidoPaterno, ApellidoMaterno);
                default:
                    throw new ArgumentException(string.Format("'{0}' es un formato invalido", fmt));
            }
        }

        #endregion
    }
}
