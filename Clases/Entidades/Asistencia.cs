using CENDI_admin.Clases.BD_conector;
using System.Data;
using Npgsql;

namespace CENDI_admin.Clases.Entidades
{
    
    internal class Asistencia
    {
        /// <summary>
        /// Enumera el tipo de asistencia que queremos trabajar con la clase
        /// </summary>
        [Flags]
        public enum Tipo : int
        {
            entrada = 1,
            salida = 2
        }

        public static DataTable? GetAllAsistencia(int modo)
        {
            string cmdText = modo == (int)Tipo.entrada ? "SELECT * FROM V_PERMISO_ENTRADA":"SELECT * FROM V_PERMISO_SALIDA";

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
        public static DataTable? GetReporteAsistencia(int ID_INFANTE, int año, int mes)
        {
            string cmdText = "SELECT * FROM V_REPORTE_ASISTENCIA WHERE EXTRACT(YEAR FROM FECHA) = @AÑO AND EXTRACT(MONTH FROM FECHA) = @MES AND ID_INFANTE = @ID_INFANTE ORDER BY FECHA ASC";

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
                        cmdDB.Parameters.AddWithValue("@AÑO", NpgsqlTypes.NpgsqlDbType.Integer, año);
                        cmdDB.Parameters.AddWithValue("@MES", NpgsqlTypes.NpgsqlDbType.Integer, mes);
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, ID_INFANTE);

                        NpgsqlDataAdapter da = new(cmdDB);

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
        public static DataTable? GetReporteAsistencia(DateTime fecha, int noSalon)
        {
            string cmdText = "SELECT * FROM V_REPORTE_ASISTENCIA WHERE FECHA = @fecha AND NO_SALON = @noSalon ORDER BY AP_INFANTE ASC";

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
                        cmdDB.Parameters.AddWithValue("@fecha", NpgsqlTypes.NpgsqlDbType.Date, fecha.Date);
                        cmdDB.Parameters.AddWithValue("@noSalon", NpgsqlTypes.NpgsqlDbType.Integer, noSalon);

                        NpgsqlDataAdapter da = new(cmdDB);

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
        public static DataTable? GetReporteAsistenciaSalon(int noSalon, int año, int mes)
        {
            string cmdText = "SELECT * FROM V_REPORTE_ASISTENCIA WHERE EXTRACT(YEAR FROM FECHA) = @AÑO AND EXTRACT(MONTH FROM FECHA) = @MES AND NO_SALON = @noSalon ORDER BY ID_INFANTE ASC";

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
                        cmdDB.Parameters.AddWithValue("@AÑO", NpgsqlTypes.NpgsqlDbType.Integer, año);
                        cmdDB.Parameters.AddWithValue("@MES", NpgsqlTypes.NpgsqlDbType.Integer, mes);
                        cmdDB.Parameters.AddWithValue("@noSalon", NpgsqlTypes.NpgsqlDbType.Integer, noSalon);

                        NpgsqlDataAdapter da = new(cmdDB);

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

        public static DataTable? GetAsistencia(int modo, int noSalon, DateTime fechaConsulta)
        {
            string cmdText = modo == (int)Tipo.entrada ? "SELECT * FROM V_PERMISO_ENTRADA WHERE FECHA = @fechaConsulta AND NO_SALON = @noSalon" : "SELECT * FROM V_PERMISO_SALIDA WHERE FECHA = @fechaConsulta AND NO_SALON = @noSalon";
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
                        cmdDB.Parameters.AddWithValue("@fechaConsulta", NpgsqlTypes.NpgsqlDbType.Date, fechaConsulta);
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
        public static DataTable? GetAsistencia(int modo, int noReg)
        {
            string cmdText = modo == (int)Tipo.entrada ? "SELECT * FROM V_PERMISO_ENTRADA WHERE NO_REG_ENTRADA = @noReg":"SELECT * FROM V_PERMISO_SALIDA WHERE NO_REG_SALIDA = @noReg";
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
                        cmdDB.Parameters.AddWithValue("@noReg", NpgsqlTypes.NpgsqlDbType.Integer, noReg);

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

        public static void NewAsistenica(int modo, int noInfante, int noTutor, DateTime fecha, TimeSpan hora , string notas)
        {
            string cmdText = modo == (int)Tipo.entrada ? "CALL P_REGISTRO_ENTRADA_NUEVO (@noTutor, @noInfante, @fecha, @hora, @notas)" : "CALL P_REGISTRO_SALIDA_NUEVO (@noTutor, @noInfante, @fecha, @hora, @notas)";
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
                        cmdDB.Parameters.AddWithValue("@noTutor", NpgsqlTypes.NpgsqlDbType.Integer, noTutor);
                        cmdDB.Parameters.AddWithValue("@noInfante", NpgsqlTypes.NpgsqlDbType.Integer, noInfante);
                        cmdDB.Parameters.AddWithValue("@fecha", NpgsqlTypes.NpgsqlDbType.Date, fecha.Date);
                        cmdDB.Parameters.AddWithValue("@hora", NpgsqlTypes.NpgsqlDbType.Time, hora);
                        cmdDB.Parameters.AddWithValue("@notas", NpgsqlTypes.NpgsqlDbType.Varchar, notas);

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
        public static void UpdateAsistenciaObservaciones(int modo, int noReg, string observaciones)
        {
            string cmdText = modo == (int)Tipo.entrada ? "CALL P_REGISTRO_ENTRADA_CAMBIAR_DATOS(@noReg, @observaciones)": "CALL P_REGISTRO_SALIDA_CAMBIAR_DATOS(@noReg, @observaciones)";

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
                        cmdDB.Parameters.AddWithValue("@noReg", NpgsqlTypes.NpgsqlDbType.Integer, noReg);
                        cmdDB.Parameters.AddWithValue("@observaciones", NpgsqlTypes.NpgsqlDbType.Varchar, observaciones);

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
        public static void DeleteAsistencia(int modo, int noReg)
        {
            string cmdText = modo == (int)Tipo.entrada ? "CALL P_REGISTRO_ENTRADA_ELIMINAR (@noReg)": "CALL P_REGISTRO_SALIDA_ELIMINAR (@noReg)";
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
                        cmdDB.Parameters.AddWithValue("@noReg", NpgsqlTypes.NpgsqlDbType.Integer, noReg);
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
