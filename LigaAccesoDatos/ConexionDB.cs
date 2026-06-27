using Microsoft.Data.SqlClient;

namespace LigaAccesoDatos
{
    public class ConexionDB
    {
        private static readonly string _cadena =
            @"Server=.;Database=LigaDeportiva;" +
            "Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection ObtenerConexion()
        {
            var conexion = new SqlConnection(_cadena);
            conexion.Open();
            return conexion;
        }
    }
}