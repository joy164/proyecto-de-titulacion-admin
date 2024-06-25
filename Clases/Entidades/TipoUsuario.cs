using CENDI_admin.Clases.BD_conector;
using Npgsql;
using System.Data;

namespace CENDI_admin.Clases.Entidades
{
    internal class TipoUsuario
    {
        public static DataTable? GetRoleUsers()
        {
            string cmdText = "SELECT ID_TIPO_USUARIO, DESCRIPCION AS ROL FROM TIPO_USUARIO ORDER BY ID_TIPO_USUARIO ASC";
            NpgsqlConnection? conn;
            DataSet dataSet = new();

            DataTable dataSetFinal = new();
            dataSetFinal.Columns.Add("clave", typeof(int));
            dataSetFinal.Columns.Add("texto", typeof(string));

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

                        foreach (DataRow fila in dataSet.Tables[0].Rows)
                            dataSetFinal.Rows.Add((int)fila["ID_TIPO_USUARIO"], (string)fila["ROL"]);
                    }
                }

            }
            catch (NpgsqlException e)
            {
                throw new NpgsqlException(e.Message);
            }

            ConectorPostgreSQL.TermConexion(conn);
            return dataSetFinal;
        }

    }
}
