using CENDI_admin.Clases.BD_conector;
using CENDI_admin.Clases.Utils;
using Npgsql;
using System.Data;

namespace CENDI_admin.Clases.Entidades
{
    internal class Infante
    {
        public static DataTable? GetAllInfante(bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM V_DATOS_INFANTE_COMPLETO";

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
        public static DataTable? GetInfante(int noInfante)
        {
            string cmdText = "SELECT * FROM V_DATOS_INFANTE_COMPLETO WHERE ID_INFANTE = @noInfante";
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
                        cmdDB.Parameters.AddWithValue("@noInfante", NpgsqlTypes.NpgsqlDbType.Integer, noInfante);

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
        public static int GetInfanteID(string CURP)
        {
            string cmdText = "SELECT ID_INFANTE FROM INFANTE WHERE CURP = @CURP";
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
                        cmdDB.Parameters.AddWithValue("@CURP", NpgsqlTypes.NpgsqlDbType.Varchar, CURP);

                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
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
            return (int)dataSet.Tables[0].Rows[0]["ID_INFANTE"];
        }
        public static void NewInfante(int NO_SALON, Image IMG_INFANTE, Nombre nombre, string CURP, LugarNac nacimiento, Edad edad, char SEXO_INFANTE)
        {
            string cmdText = "CALL P_INFANTE_NUEVO (@NO_SALON, @IMG_INFANTE, @NOM_INFANTE, @AP_INFANTE, @AM_INFANTE, @CURP, @FECHA_NAC, @LUGAR_NAC, @EDAD_INFANTE, @MESES_INFANTE, @SEXO_INFANTE)";
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
                        cmdDB.Parameters.AddWithValue("@NO_SALON", NpgsqlTypes.NpgsqlDbType.Integer, NO_SALON);
                        cmdDB.Parameters.AddWithValue("@IMG_INFANTE", NpgsqlTypes.NpgsqlDbType.Bytea, Imagenes.ImagenToByteArray(IMG_INFANTE));
                        cmdDB.Parameters.AddWithValue("@NOM_INFANTE", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.Nombres);
                        cmdDB.Parameters.AddWithValue("@AP_INFANTE", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoPaterno);
                        cmdDB.Parameters.AddWithValue("@AM_INFANTE", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoMaterno);
                        cmdDB.Parameters.AddWithValue("@CURP", NpgsqlTypes.NpgsqlDbType.Varchar, CURP);
                        cmdDB.Parameters.AddWithValue("@FECHA_NAC", NpgsqlTypes.NpgsqlDbType.Date, nacimiento.FechaNac.Date);
                        cmdDB.Parameters.AddWithValue("@LUGAR_NAC", NpgsqlTypes.NpgsqlDbType.Integer, nacimiento.LugarNacimiento);
                        cmdDB.Parameters.AddWithValue("@EDAD_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, edad.Año);
                        cmdDB.Parameters.AddWithValue("@MESES_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, edad.Mes);
                        cmdDB.Parameters.AddWithValue("@SEXO_INFANTE", NpgsqlTypes.NpgsqlDbType.Char, SEXO_INFANTE);

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
        public static void UpdateInfanteData(int noInfante, int NO_SALON, Image IMG_INFANTE, Nombre nombre, string CURP, LugarNac nacimiento, Edad edad, char SEXO_INFANTE)
        {
            string cmdText = "CALL P_INFANTE_CAMBIAR_DATOS(@ID_INFANTE, @NO_SALON, @IMG_INFANTE, @NOM_INFANTE, @AP_INFANTE, @AM_INFANTE, @CURP, @FECHA_NAC, @LUGAR_NAC, @EDAD_INFANTE, @MESES_INFANTE, @SEXO_INFANTE)";
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
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, noInfante);
                        cmdDB.Parameters.AddWithValue("@NO_SALON", NpgsqlTypes.NpgsqlDbType.Integer, NO_SALON);
                        cmdDB.Parameters.AddWithValue("@IMG_INFANTE", NpgsqlTypes.NpgsqlDbType.Bytea, Imagenes.ImagenToByteArray(IMG_INFANTE));
                        cmdDB.Parameters.AddWithValue("@NOM_INFANTE", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.Nombres);
                        cmdDB.Parameters.AddWithValue("@AP_INFANTE", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoPaterno);
                        cmdDB.Parameters.AddWithValue("@AM_INFANTE", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoMaterno);
                        cmdDB.Parameters.AddWithValue("@CURP", NpgsqlTypes.NpgsqlDbType.Varchar, CURP);
                        cmdDB.Parameters.AddWithValue("@FECHA_NAC", NpgsqlTypes.NpgsqlDbType.Date, nacimiento.FechaNac.Date);
                        cmdDB.Parameters.AddWithValue("@LUGAR_NAC", NpgsqlTypes.NpgsqlDbType.Integer, nacimiento.LugarNacimiento);
                        cmdDB.Parameters.AddWithValue("@EDAD_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, edad.Año);
                        cmdDB.Parameters.AddWithValue("@MESES_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, edad.Mes);
                        cmdDB.Parameters.AddWithValue("@SEXO_INFANTE", NpgsqlTypes.NpgsqlDbType.Char, SEXO_INFANTE);

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
        public static void UpdateInfanteData(int noInfante, int NO_SALON, Image IMG_INFANTE)
        {
            string cmdText = "CALL P_INFANTE_CAMBIAR_DATOS(@ID_INFANTE, @NO_SALON, @IMG_INFANTE)";
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
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, noInfante);
                        cmdDB.Parameters.AddWithValue("@NO_SALON", NpgsqlTypes.NpgsqlDbType.Integer, NO_SALON);
                        cmdDB.Parameters.AddWithValue("@IMG_INFANTE", NpgsqlTypes.NpgsqlDbType.Bytea, Imagenes.ImagenToByteArray(IMG_INFANTE));

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
        public static void DeleteInfante(int noInfante)
        {
            string cmdText = "CALL P_INFANTE_ELIMINAR (@ID_INFANTE)";
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
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", NpgsqlTypes.NpgsqlDbType.Integer, noInfante);
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
