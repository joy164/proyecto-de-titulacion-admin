using CENDI_admin.Clases.BD_conector;
using Npgsql;
using System.Data;

namespace CENDI_admin.Clases.Entidades
{
    internal class Salon
    {
        public static DataTable? GetAllSalon(bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM V_SALON ORDER BY NO_SALON ASC";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "SIN SALON ASIGNADO");

            NpgsqlConnection? conn;
            DataSet dataSet = new();

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorPostgreSQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new NpgsqlException("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos
                    using (NpgsqlDataAdapter da = new(new NpgsqlCommand(cmdText, conn)))
                    {
                        if (da.Fill(dataSet) == 0)
                            return null;

                        if (paraComboBox)
                            foreach (DataRow fila in dataSet.Tables[0].Rows)
                                dataSetFinal.Rows.Add((int)fila["NO_SALON"], string.Format("{0} {1}°-{2}", (string)fila["NIVEL"], (string)fila["GRADO"], (string)fila["GRUPO"]));
                    }
                }

            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

            ConectorPostgreSQL.TermConexion(conn);

            var res = paraComboBox ? dataSetFinal : dataSet.Tables[0];
            return res;
        }
        public static int GetNoSalon()
        {
            string cmdText = "SELECT * FROM V_SALON ORDER BY NO_SALON ASC";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "SIN SALON ASIGNADO");

            NpgsqlConnection? conn;
            DataSet dataSet = new();

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorPostgreSQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new NpgsqlException("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos
                    using (NpgsqlDataAdapter da = new(new NpgsqlCommand(cmdText, conn)))
                    {
                        if (da.Fill(dataSet) == 0)
                            return 0;
                    }
                }

            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

            ConectorPostgreSQL.TermConexion(conn);

            return dataSet.Tables[0].Rows.Count;
        }
        public static DataTable? GetInfanteSalon(int noSalon)
        {
            string cmdText = "SELECT * FROM V_DATOS_INFANTE_COMPLETO WHERE NO_SALON = @noSalon ORDER BY AP_PAT ASC";
            NpgsqlConnection? conn;
            DataSet dataSet = new();

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorPostgreSQL.InitConexion())
                {

                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new NpgsqlException("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (NpgsqlCommand cmdDB = new NpgsqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@noSalon", NpgsqlTypes.NpgsqlDbType.Integer, noSalon);

                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;
                    }
                }

            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

            ConectorPostgreSQL.TermConexion(conn);
            return dataSet.Tables[0];
        }
        public static DataTable? GetSalon(int noSalon)
        {
            string cmdText = "SELECT * FROM V_SALON WHERE NO_SALON = @noSalon";
            NpgsqlConnection? conn;
            DataSet dataSet = new();

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorPostgreSQL.InitConexion())
                {

                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new NpgsqlException("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (NpgsqlCommand cmdDB = new NpgsqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@noSalon", NpgsqlTypes.NpgsqlDbType.Integer, noSalon);

                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;
                    }
                }

            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

            ConectorPostgreSQL.TermConexion(conn);
            return dataSet.Tables[0];
        }
        public static void NewSalon(int noNivel, char grupo)
        {
            string cmdText = "CALL P_SALON_NUEVO (@NO_NIVEL, @GRUPO)";
            NpgsqlConnection? conn;

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorPostgreSQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new NpgsqlException("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (NpgsqlCommand cmdDB = new(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@NO_NIVEL", NpgsqlTypes.NpgsqlDbType.Integer, noNivel);
                        cmdDB.Parameters.AddWithValue("@GRUPO", NpgsqlTypes.NpgsqlDbType.Char, grupo);

                        cmdDB.ExecuteNonQuery();
                    }

                }
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
            ConectorPostgreSQL.TermConexion(conn);
        }
        public static void UpdateSalonData(int noSalon, int noNivel, char grupo)
        {
            string cmdText = "CALL P_SALON_CAMBIAR_DATOS (@NO_SALON, @NO_NIVEL, @GRUPO)";
            NpgsqlConnection? conn;

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorPostgreSQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new NpgsqlException("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (NpgsqlCommand cmdDB = new(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@NO_SALON", NpgsqlTypes.NpgsqlDbType.Integer, noSalon);
                        cmdDB.Parameters.AddWithValue("@NO_NIVEL", NpgsqlTypes.NpgsqlDbType.Integer, noNivel);
                        cmdDB.Parameters.AddWithValue("@GRUPO", NpgsqlTypes.NpgsqlDbType.Char, grupo);

                        cmdDB.ExecuteNonQuery();
                    }

                }
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
            ConectorPostgreSQL.TermConexion(conn);
        }
        public static void DeleteSalon(int noSalon)
        {
            string cmdText = "CALL P_SALON_ELIMINAR (@NO_SALON)";
            NpgsqlConnection? conn;

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorPostgreSQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new NpgsqlException("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (NpgsqlCommand cmdDB = new(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@NO_SALON", NpgsqlTypes.NpgsqlDbType.Integer, noSalon);
                        cmdDB.ExecuteNonQuery();
                    }

                }
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }
            ConectorPostgreSQL.TermConexion(conn);
        }
    }
}
