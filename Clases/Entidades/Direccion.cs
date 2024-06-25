using CENDI_admin.Clases.BD_conector;
using Npgsql;
using System.Data;

namespace CENDI_admin.Clases.Entidades
{
    internal class Direccion
    {
        public int ID_Colonia { get; set; }
        public int ID_Municipio { get; set; }
        public int ID_Estado { get; set; }
        public string? Calle { get; set; }
        public string? No_ext { get; set; }
        public string? No_int { get; set; }

        public Direccion(int iD_Colonia, int iD_Municipio, int iD_Estado, string? calle, string? no_ext, string? no_int)
        {
            ID_Colonia = iD_Colonia;
            ID_Municipio = iD_Municipio;
            ID_Estado = iD_Estado;
            Calle = calle;
            No_ext = no_ext;
            No_int = no_int;
        }
        public Direccion()
        {
        }

        public static DataTable? GetAllDirecciones(bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM V_DIRECCION_COMPLETA";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "SIN DIRECCION SELECCIONADA");

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
                                dataSetFinal.Rows.Add((int)fila["ID_DIRECCION"], string.Format("{0} {1} / {2} {3}", (string)fila["CALLE"], (string)fila["NO_EXT"], (string)fila["NO_INT"], (string)fila["colonia"]));
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
        public static DataTable? GetDireccion(int noDireccion)
        {
            string cmdText = "SELECT * FROM V_DIRECCION_COMPLETA WHERE ID_DIRECCION = @noDireccion";
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
                        cmdDB.Parameters.AddWithValue("@noDireccion", NpgsqlTypes.NpgsqlDbType.Integer, noDireccion);

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
        public static void NewDireccion(int ID_COLONIA, int ID_MUNICIPIO, int ID_ESTADO, string CALLE, string NO_EXT, string NO_INT)
        {
            string cmdText = "CALL P_DIRECCION_NUEVO(@ID_COLONIA, @ID_MUNICIPIO, @ID_ESTADO, @CALLE, @NO_EXT, @NO_INT)";
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
                        cmdDB.Parameters.AddWithValue("@ID_COLONIA", NpgsqlTypes.NpgsqlDbType.Integer, ID_COLONIA);
                        cmdDB.Parameters.AddWithValue("@ID_MUNICIPIO", NpgsqlTypes.NpgsqlDbType.Integer, ID_MUNICIPIO);
                        cmdDB.Parameters.AddWithValue("@ID_ESTADO", NpgsqlTypes.NpgsqlDbType.Integer, ID_ESTADO);
                        cmdDB.Parameters.AddWithValue("@CALLE", NpgsqlTypes.NpgsqlDbType.Varchar, CALLE);
                        cmdDB.Parameters.AddWithValue("@NO_EXT", NpgsqlTypes.NpgsqlDbType.Varchar, NO_EXT);
                        cmdDB.Parameters.AddWithValue("@NO_INT", NpgsqlTypes.NpgsqlDbType.Varchar, NO_INT);

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
        public static void UpdateDireccionData(int noDireccion, int ID_COLONIA, int ID_MUNICIPIO, int ID_ESTADO, string CALLE, string NO_EXT, string NO_INT)
        {
            string cmdText = "CALL P_DIRECCION_CAMBIAR_DATOS(@ID_DIRECCION, @ID_COLONIA, @ID_MUNICIPIO, @ID_ESTADO, @CALLE, @NO_EXT, @NO_INT)";
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
                        cmdDB.Parameters.AddWithValue("@ID_DIRECCION", NpgsqlTypes.NpgsqlDbType.Integer, noDireccion);
                        cmdDB.Parameters.AddWithValue("@ID_COLONIA", NpgsqlTypes.NpgsqlDbType.Integer, ID_COLONIA);
                        cmdDB.Parameters.AddWithValue("@ID_MUNICIPIO", NpgsqlTypes.NpgsqlDbType.Integer, ID_MUNICIPIO);
                        cmdDB.Parameters.AddWithValue("@ID_ESTADO", NpgsqlTypes.NpgsqlDbType.Integer, ID_ESTADO);
                        cmdDB.Parameters.AddWithValue("@CALLE", NpgsqlTypes.NpgsqlDbType.Varchar, CALLE);
                        cmdDB.Parameters.AddWithValue("@NO_EXT", NpgsqlTypes.NpgsqlDbType.Varchar, NO_EXT);
                        cmdDB.Parameters.AddWithValue("@NO_INT", NpgsqlTypes.NpgsqlDbType.Varchar, NO_INT);

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
        public static void DeleteDireccion(int noDireccion)
        {
            string cmdText = "CALL P_DIRECCION_ELIMINAR (@ID_DIRECCION)";
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
                        cmdDB.Parameters.AddWithValue("@ID_DIRECCION", NpgsqlTypes.NpgsqlDbType.Integer, noDireccion);

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

        public static DataTable? GetEstado(bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM ESTADO ORDER BY NOMBRE ASC";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "ESTADO NO SELECCIONADO");

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
                        NpgsqlDataAdapter da = new(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;

                        if (paraComboBox)
                            foreach (DataRow fila in dataSet.Tables[0].Rows)
                                dataSetFinal.Rows.Add((int)fila["ID_ESTADO"], (string)fila["NOMBRE"]);
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
        public static DataTable? GetMunicipios(int noEstado, bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM MUNICIPIO WHERE ESTADO = @estado ORDER BY NOMBRE ASC";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "MUNICIPIO NO SELECCIONADO");

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
                        cmdDB.Parameters.AddWithValue("@estado", NpgsqlTypes.NpgsqlDbType.Integer, noEstado);

                        NpgsqlDataAdapter da = new(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;

                        if (paraComboBox)
                            foreach (DataRow fila in dataSet.Tables[0].Rows)
                                dataSetFinal.Rows.Add((int)fila["ID_MUNICIPIO"], (string)fila["NOMBRE"]);
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
        public static DataTable? GetColonias(int noMunicipio, bool paraComboBox = false)
        {
            string cmdText = "SELECT * FROM COLONIA WHERE MUNICIPIO = @noMunicipio ORDER BY NOMBRE ASC";

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));
            dataSetFinal.Rows.Add(null, "MUNICIPIO NO SELECCIONADO");

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
                        cmdDB.Parameters.AddWithValue("@noMunicipio", NpgsqlTypes.NpgsqlDbType.Integer, noMunicipio);

                        NpgsqlDataAdapter da = new(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;

                        if (paraComboBox)
                            foreach (DataRow fila in dataSet.Tables[0].Rows)
                                dataSetFinal.Rows.Add((int)fila["ID_COLONIA"], (string)fila["NOMBRE"]);
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

    }
}
