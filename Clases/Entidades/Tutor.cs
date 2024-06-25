using CENDI_admin.Clases.BD_conector;
using CENDI_admin.Clases.Utils;
using System.Data;
using Npgsql;

namespace CENDI_admin.Clases.Entidades
{
    internal class Tutor
    {
        public static DataTable? GetAllTutores(bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM V_DATOS_TUTOR_COMPLETO ORDER BY AP_PAT ASC, AP_MAT ASC";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "SIN TUTOR ASIGNADO");

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
                                Nombre nom = new Nombre((string)fila["NOMBRES"], (string)fila["AP_PAT"], (string)fila["AP_MAT"]);
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
        public static DataTable? GetTutor(int noTutor)
        {
            string cmdText = "SELECT * FROM V_DATOS_TUTOR_COMPLETO WHERE ID_TUTOR = @noTutor";
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
                        cmdDB.Parameters.AddWithValue("@noTutor", NpgsqlTypes.NpgsqlDbType.Integer, noTutor);

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
        public static int GetTutorID(string TEL_CELULAR)
        {
            string cmdText = "SELECT ID_TUTOR FROM V_DATOS_TUTOR_COMPLETO WHERE TEL_CELULAR = @TEL_CELULAR";
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
                        cmdDB.Parameters.AddWithValue("@TEL_CELULAR", NpgsqlTypes.NpgsqlDbType.Varchar, TEL_CELULAR);

                        NpgsqlDataAdapter da = new(cmdDB);

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
            return (int)dataSet.Tables[0].Rows[0]["ID_TUTOR"];
        }
        public static void NewTutor(int ID_PARENTESCO, Image IMG_TUTOR, Nombre nombre, string TEL_CELULAR, string? TEL_FIJO, Direccion direccion)
        {
            string cmdText = "CALL P_TUTOR_DIRECCION_NUEVO(@ID_PARENTESCO, @IMG_TUTOR, @NOM_TUTOR, @AP_TUTOR, @AM_TUTOR, @TEL_CELULAR, @TEL_FIJO, @ID_COLONIA, @ID_MUNICIPIO, @ID_ESTADO, @CALLE, @NO_EXT, @NO_INT)";
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
                        cmdDB.Parameters.AddWithValue("@ID_PARENTESCO", NpgsqlTypes.NpgsqlDbType.Integer, ID_PARENTESCO);
                        cmdDB.Parameters.AddWithValue("@IMG_TUTOR", NpgsqlTypes.NpgsqlDbType.Bytea, Imagenes.ImagenToByteArray(IMG_TUTOR));
                        cmdDB.Parameters.AddWithValue("@NOM_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.Nombres);
                        cmdDB.Parameters.AddWithValue("@AP_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoPaterno);
                        cmdDB.Parameters.AddWithValue("@AM_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoMaterno);
                        cmdDB.Parameters.AddWithValue("@TEL_CELULAR", NpgsqlTypes.NpgsqlDbType.Varchar, TEL_CELULAR);
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                        cmdDB.Parameters.AddWithValue("@TEL_FIJO", NpgsqlTypes.NpgsqlDbType.Varchar, ((object)TEL_FIJO) ?? DBNull.Value);
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                        cmdDB.Parameters.AddWithValue("@ID_COLONIA", NpgsqlTypes.NpgsqlDbType.Integer, direccion.ID_Colonia);
                        cmdDB.Parameters.AddWithValue("@ID_MUNICIPIO", NpgsqlTypes.NpgsqlDbType.Integer, direccion.ID_Municipio);
                        cmdDB.Parameters.AddWithValue("@ID_ESTADO", NpgsqlTypes.NpgsqlDbType.Integer, direccion.ID_Estado);
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                        cmdDB.Parameters.AddWithValue("@CALLE", NpgsqlTypes.NpgsqlDbType.Varchar, direccion.Calle);
                        cmdDB.Parameters.AddWithValue("@NO_EXT", NpgsqlTypes.NpgsqlDbType.Varchar, direccion.No_ext);
                        cmdDB.Parameters.AddWithValue("@NO_INT", NpgsqlTypes.NpgsqlDbType.Varchar, direccion.No_int);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
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
        public static void NewTutor(int ID_PARENTESCO, Image IMG_TUTOR, Nombre nombre, string TEL_CELULAR, string? TEL_FIJO, int ID_direccion)
        {
            string cmdText = "CALL P_TUTOR_NUEVO(@ID_PARENTESCO, @ID_DIRECCION, @IMG_TUTOR, @NOM_TUTOR, @AP_TUTOR, @AM_TUTOR, @TEL_CELULAR, @TEL_FIJO)";
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
                        cmdDB.Parameters.AddWithValue("@ID_PARENTESCO", NpgsqlTypes.NpgsqlDbType.Integer, ID_PARENTESCO);
                        cmdDB.Parameters.AddWithValue("@IMG_TUTOR", NpgsqlTypes.NpgsqlDbType.Bytea, Imagenes.ImagenToByteArray(IMG_TUTOR));
                        cmdDB.Parameters.AddWithValue("@NOM_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.Nombres);
                        cmdDB.Parameters.AddWithValue("@AP_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoPaterno);
                        cmdDB.Parameters.AddWithValue("@AM_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoMaterno);
                        cmdDB.Parameters.AddWithValue("@TEL_CELULAR", NpgsqlTypes.NpgsqlDbType.Varchar, TEL_CELULAR);
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                        cmdDB.Parameters.AddWithValue("@TEL_FIJO", NpgsqlTypes.NpgsqlDbType.Varchar, ((object)TEL_FIJO) ?? DBNull.Value);
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                        cmdDB.Parameters.AddWithValue("@ID_DIRECCION", NpgsqlTypes.NpgsqlDbType.Integer, ID_direccion);

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
        public static void UpdateTutorData(int noTutor, int ID_PARENTESCO, Image IMG_TUTOR, Nombre nombre, string TEL_CELULAR, string? TEL_FIJO, int ID_direccion)
        {
            string cmdText = "CALL P_TUTOR_CAMBIAR_DATOS(@ID_TUTOR, @ID_PARENTESCO, @ID_DIRECCION, @IMG_TUTOR, @NOM_TUTOR, @AP_TUTOR, @AM_TUTOR, @TEL_CELULAR, @TEL_FIJO)";
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
                        cmdDB.Parameters.AddWithValue("@ID_TUTOR", NpgsqlTypes.NpgsqlDbType.Integer, noTutor);
                        cmdDB.Parameters.AddWithValue("@ID_PARENTESCO", NpgsqlTypes.NpgsqlDbType.Integer, ID_PARENTESCO);
                        cmdDB.Parameters.AddWithValue("@IMG_TUTOR", NpgsqlTypes.NpgsqlDbType.Bytea, Imagenes.ImagenToByteArray(IMG_TUTOR));
                        cmdDB.Parameters.AddWithValue("@NOM_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.Nombres);
                        cmdDB.Parameters.AddWithValue("@AP_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoMaterno);
                        cmdDB.Parameters.AddWithValue("@AM_TUTOR", NpgsqlTypes.NpgsqlDbType.Varchar, nombre.ApellidoMaterno);
                        cmdDB.Parameters.AddWithValue("@TEL_CELULAR", NpgsqlTypes.NpgsqlDbType.Varchar, TEL_CELULAR);
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                        cmdDB.Parameters.AddWithValue("@TEL_FIJO", NpgsqlTypes.NpgsqlDbType.Varchar, ((object)TEL_FIJO) ?? DBNull.Value);
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                        cmdDB.Parameters.AddWithValue("@ID_DIRECCION", NpgsqlTypes.NpgsqlDbType.Integer, ID_direccion);

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
        public static void UpdateTutorDirID(int noTutor, int ID_direccion)
        {
            string cmdText = "CALL P_TUTOR_CAMBIAR_DIRECION(@ID_TUTOR, @ID_DIRECCION)";
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
                        cmdDB.Parameters.AddWithValue("@ID_TUTOR", NpgsqlTypes.NpgsqlDbType.Integer, noTutor);
                        cmdDB.Parameters.AddWithValue("@ID_DIRECCION", NpgsqlTypes.NpgsqlDbType.Integer, ID_direccion);

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
        public static void DeleteTutor(int noInfante)
        {
            string cmdText = "CALL P_TUTOR_ELIMINAR (@ID_INFANTE)";
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
