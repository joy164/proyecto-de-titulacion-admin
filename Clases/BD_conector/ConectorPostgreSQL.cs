using CENDI_admin.Properties;
using Npgsql;

namespace CENDI_admin.Clases.BD_conector
{
    internal class ConectorPostgreSQL
    {
        #region Atributos

        private static string Host { get; set; } = Settings.Default.host;
        private static string Name_db { get; set; } = Settings.Default.name_db;
        private static string Port { get; set; } = Settings.Default.port;
        private static string User { get; set; } = Settings.Default.user;
        private static string Password { get; set; } = Settings.Default.password;

        private static readonly string Cad_conexion = "Server=" + Host + ";Username= " + User + ";Database= " + Name_db + " ;Port= " + Port + ";Password= " + Password + ";Pooling=false;";

        #endregion

        #region Metodos

        /// <summary>
        /// Incializa la conexion con la base de datos
        /// </summary>
        /// <returns>Un objeto con la conexion de base de datos tipo NpgsqlConnection</returns>
        /// <exception cref="NpgsqlException">Succede cuando hay una excepcion en el manejador de base de datos</exception>
        public static NpgsqlConnection InitConexion()
        {
            NpgsqlConnection conn = new NpgsqlConnection()
            {
                ConnectionString = Cad_conexion
            };

            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    return conn;
                else
                    conn.Open();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException(ex.Message);
            }
            return conn;
        }

        /// <summary>
        /// Prueba si la configuracion realizada permite conectarse a la base de datos
        /// </summary>
        /// <param name="cadenaConexion">cadena test de conexion</param>
        /// <returns>Un objeto con la conexion de base de datos tipo NpgsqlConnection</returns>
        /// <exception cref="NpgsqlException">Succede cuando hay una excepcion en el manejador de base de datos</exception>
        public static NpgsqlConnection TestConexion(string cadenaConexion)
        {
            NpgsqlConnection conn = new NpgsqlConnection()
            {
                ConnectionString = cadenaConexion
            };

            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    return conn;
                else
                    conn.Open();
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException(ex.Message);
            }
            return conn;
        }

        /// <summary>
        /// Cierra y libera recursos generados en la conexion con la base de datos
        /// </summary>
        /// <param name="conn">Objeto de la clase NpgsqlConnection con la conexion abierta</param>
        /// <exception cref="NpgsqlException">Succede cuando hay una excepcion en el manejador de base de datos</exception>
        public static void TermConexion(NpgsqlConnection conn)
        {
            try
            {
                if (conn != null)
                {
                    conn.Dispose();
                    NpgsqlConnection.ClearPool(conn);
                    conn.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException(ex.Message);
            }
        }

        #endregion
    }
}
