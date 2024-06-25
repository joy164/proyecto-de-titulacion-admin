using CENDI_admin.Clases.BD_conector;
using Npgsql;
using System.Data;

namespace CENDI_admin.Clases.Entidades
{
    internal class Parentesco
    {
        public static DataTable? GetAllParentesco(bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM PARENTESCO";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "SIN PARENTESCO SELECCIONADO");

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
                                dataSetFinal.Rows.Add((int)fila["ID_PARENTESCO"], (string)fila["NOM_PARENTESCO"]);
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
        public static DataTable? GetParentesco(int IDParentesco)
        {
            string cmdText = "SELECT * FROM PARENTESCO WHERE ID_PARENTESCO = @IDParentesco";
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
                        cmdDB.Parameters.AddWithValue("@IDParentesco", NpgsqlTypes.NpgsqlDbType.Integer, IDParentesco);

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
        public static void NewParentesco(string nomParentesco, int jerarquia)
        {
            string cmdText = "CALL P_PARENTESCO_NUEVO (@NOM_PARENTESCO, @JERARQUIA)";
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
                        cmdDB.Parameters.AddWithValue("@NOM_PARENTESCO", NpgsqlTypes.NpgsqlDbType.Varchar, nomParentesco);
                        cmdDB.Parameters.AddWithValue("@JERARQUIA", NpgsqlTypes.NpgsqlDbType.Integer, jerarquia);

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
        public static void UpdateParentescoData(int IDParentesco, string nomParentesco, int jerarquia)
        {
            string cmdText = "CALL P_PARENTESCO_CAMBIAR_DATOS (@ID_PARENTESCO, @NOM_PARENTESCO, @JERARQUIA)";
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
                        cmdDB.Parameters.AddWithValue("@ID_PARENTESCO", NpgsqlTypes.NpgsqlDbType.Integer, IDParentesco);
                        cmdDB.Parameters.AddWithValue("@NOM_PARENTESCO", NpgsqlTypes.NpgsqlDbType.Varchar, nomParentesco);
                        cmdDB.Parameters.AddWithValue("@JERARQUIA", NpgsqlTypes.NpgsqlDbType.Integer, jerarquia);

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
        public static void DeleteParentesco(int IDParentesco)
        {
            string cmdText = "CALL P_PARENTESCO_ELIMINAR(@ID_PARENTESCO)";
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
                        cmdDB.Parameters.AddWithValue("@ID_PARENTESCO", NpgsqlTypes.NpgsqlDbType.Integer, IDParentesco);

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
