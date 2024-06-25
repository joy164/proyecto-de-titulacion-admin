using CENDI_admin.Clases.BD_conector;
using Npgsql;
using System.Data;

namespace CENDI_admin.Clases.Entidades
{
    internal class CicloEscolar
    {
        public static DataTable? GetAllCiclos(bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM CICLO_ESCOLAR ORDER BY FECHA_INICIO ASC";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "CICLO NO SELECCIONADO");

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
                            {
                                DateTime fechaInicio = (DateTime)fila["FECHA_INICIO"];
                                DateTime fechaCierre = (DateTime)fila["FECHA_CIERRE"];
                                dataSetFinal.Rows.Add((int)fila["ID_CICLO"], string.Format("Ciclo {0} - {1}", fechaInicio.Year, fechaCierre.Year));
                            }

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
        public static DataTable? GetCiclo(int noSalon)
        {
            string cmdText = "SELECT * FROM CICLO_ESCOLAR WHERE ID_CICLO = @idCiclo";
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
                    using (NpgsqlCommand cmdDB = new(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@idCiclo", NpgsqlTypes.NpgsqlDbType.Integer, noSalon);

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
        public static int GetIDCicloActual()
        {
            string cmdText =
                "SELECT id_ciclo, fecha_inicio, fecha_cierre FROM CICLO_ESCOLAR " +
                "WHERE " +
                "(CURRENT_DATE >= FECHA_INICIO AND CURRENT_DATE <= FECHA_CIERRE) " +
                "OR " +
                "(CURRENT_DATE <= FECHA_CIERRE AND CURRENT_DATE <= FECHA_INICIO) " +
                "ORDER BY FECHA_INICIO ASC LIMIT 1";

            NpgsqlConnection? conn;
            DataSet dataSet = new();
            int IDCiclo;

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
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return 0;
                        IDCiclo = (int)dataSet.Tables[0].Rows[0]["id_ciclo"];
                    }
                }
            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

            ConectorPostgreSQL.TermConexion(conn);
            return IDCiclo;
        }
        public static void NewCiclo(DateTime fechaInicio, DateTime fechaCierre)
        {
            string cmdText = "CALL P_CICLO_ESCOLAR_NUEVO (@FECHA_INICIO, @FECHA_CIERRE)";
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
                        cmdDB.Parameters.AddWithValue("@FECHA_INICIO", NpgsqlTypes.NpgsqlDbType.Date, fechaInicio);
                        cmdDB.Parameters.AddWithValue("@FECHA_CIERRE", NpgsqlTypes.NpgsqlDbType.Date, fechaCierre);

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
        public static void UpdateCicloData(int IdCiclo, DateTime fechaInicio, DateTime fechaCierre)
        {
            string cmdText = "CALL P_CICLO_ESCOLAR_CAMBIAR_DATOS (@ID_CICLO, @FECHA_INICIO, @FECHA_CIERRE)";
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
                        cmdDB.Parameters.AddWithValue("@ID_CICLO", NpgsqlTypes.NpgsqlDbType.Integer, IdCiclo);
                        cmdDB.Parameters.AddWithValue("@FECHA_INICIO", NpgsqlTypes.NpgsqlDbType.Date, fechaInicio);
                        cmdDB.Parameters.AddWithValue("@FECHA_CIERRE", NpgsqlTypes.NpgsqlDbType.Date, fechaCierre);

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
        public static void DeleteCiclo(int IdCiclo)
        {
            string cmdText = "CALL P_CICLO_ESCOLAR_ELIMINAR (@ID_CICLO)";
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
                        cmdDB.Parameters.AddWithValue("@ID_CICLO", NpgsqlTypes.NpgsqlDbType.Integer, IdCiclo);
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
