using CENDI_admin.Clases.BD_conector;
using CENDI_admin.Clases.Utils;
using Npgsql;
using System.Data;

namespace CENDI_admin.Clases.Entidades
{
    internal class InfanteTutor
    {
        public static DataTable? GetAllInfanteTutor(int ID_INFANTE, int ID_CICLO, bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM V_PERMISO_INFANTE_TUTOR WHERE ID_CICLO = @ID_CICLO AND ID_INFANTE = @ID_INFANTE";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));

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
                        cmdDB.Parameters.AddWithValue("@ID_CICLO", NpgsqlTypes.NpgsqlDbType.Integer, ID_CICLO);
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, ID_INFANTE);

                        NpgsqlDataAdapter da = new(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;

                        if (paraComboBox)
                            foreach (DataRow fila in dataSet.Tables[0].Rows)
                            {
                                Nombre nom = new Nombre((string)fila["NOM_TUTOR"], (string)fila["AP_TUTOR"], (string)fila["AM_TUTOR"]);
                                dataSetFinal.Rows.Add((int)fila["ID_TUTOR"], nom.ToString());
                            }
                    }
                }

            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

            ConectorPostgreSQL.TermConexion(conn);
            return paraComboBox ? dataSetFinal : dataSet.Tables[0];
        }
        public static DataTable? GetAllTutorInfante(int ID_TUTOR, int ID_CICLO, bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM V_PERMISO_INFANTE_TUTOR WHERE ID_CICLO = @ID_CICLO AND ID_TUTOR = @ID_TUTOR";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));

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
                        cmdDB.Parameters.AddWithValue("@ID_CICLO", NpgsqlTypes.NpgsqlDbType.Integer, ID_CICLO);
                        cmdDB.Parameters.AddWithValue("@ID_TUTOR", NpgsqlTypes.NpgsqlDbType.Integer, ID_TUTOR);

                        NpgsqlDataAdapter da = new(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;

                        if (paraComboBox)
                            foreach (DataRow fila in dataSet.Tables[0].Rows)
                            {
                                Nombre nom = new Nombre((string)fila["NOM_INFANTE"], (string)fila["AP_INFANTE"], (string)fila["AM_INFANTE"]);
                                dataSetFinal.Rows.Add((int)fila["ID_INFANTE"], nom.ToString());
                            }
                    }
                }

            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

            ConectorPostgreSQL.TermConexion(conn);
            return paraComboBox ? dataSetFinal : dataSet.Tables[0];
        }
        public static DataTable? GetInfanteTutor(int ID_TUTOR, int ID_INFANTE, int ID_CICLO)
        {
            string cmdText = "SELECT * FROM V_PERMISO_INFANTE_TUTOR WHERE ID_CICLO = @ID_CICLO AND ID_INFANTE = @ID_INFANTE AND ID_TUTOR = @ID_TUTOR";
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
                        cmdDB.Parameters.AddWithValue("@ID_CICLO", NpgsqlTypes.NpgsqlDbType.Integer, ID_CICLO);
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, ID_INFANTE);
                        cmdDB.Parameters.AddWithValue("@ID_TUTOR", NpgsqlTypes.NpgsqlDbType.Integer, ID_TUTOR);

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
        public static void NewInfanteTutor(int ID_TUTOR, int ID_INFANTE, int ID_CICLO)
        {
            string cmdText = "CALL P_INFANTE_TUTOR_NUEVO (@ID_TUTOR, @ID_INFANTE, @ID_CICLO)";
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
                        cmdDB.Parameters.AddWithValue("@ID_TUTOR", NpgsqlTypes.NpgsqlDbType.Integer, ID_TUTOR);
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, ID_INFANTE);
                        cmdDB.Parameters.AddWithValue("@ID_CICLO", NpgsqlTypes.NpgsqlDbType.Integer, ID_CICLO);

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
        public static void DeleteInfanteTutor(int ID_TUTOR, int ID_INFANTE, int ID_CICLO)
        {
            string cmdText = "CALL  P_INFANTE_TUTOR_ELIMINAR (@ID_TUTOR, @ID_INFANTE, @ID_CICLO)";
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
                        cmdDB.Parameters.AddWithValue("@ID_TUTOR", NpgsqlTypes.NpgsqlDbType.Integer, ID_TUTOR);
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, ID_INFANTE);
                        cmdDB.Parameters.AddWithValue("@ID_CICLO", NpgsqlTypes.NpgsqlDbType.Integer, ID_CICLO);

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
