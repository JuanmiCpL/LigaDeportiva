using System;
using Microsoft.Data.SqlClient;

namespace LigaAccesoDatos
{
    public class Temporada
    {
        public int Anio { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        private SqlConnection _conexion;

        // ── CONSTRUCTOR PARAMETRIZADO ─────────────────────────────────
        public Temporada(int anio, string descripcion)
        {
            Anio = anio;
            Descripcion = descripcion;
            _conexion = ConexionDB.ObtenerConexion();
        }

        // ── CONSTRUCTOR SIN PARÁMETROS ────────────────────────────────
        public Temporada()
        {
            Anio = DateTime.Now.Year;
        }

        // ── MÉTODO NORMAL ─────────────────────────────────────────────
        public string ObtenerResumen()
        {
            return $"Temporada {Anio} — {Descripcion}";
        }

        // ── DESTRUCTOR ────────────────────────────────────────────────
        // Recurso que libera: conexión activa a SQL Server (_conexion)
        // Razón: si el objeto Temporada se destruye sin haber cerrado
        // la conexión manualmente, el destructor garantiza que no quede
        // una conexión abierta consumiendo recursos del servidor.
        // Además registra en un log que la temporada fue finalizada,
        // lo cual sirve como auditoría del ciclo de vida del objeto.
        ~Temporada()
        {
            try
            {
                if (_conexion != null &&
                    _conexion.State == System.Data.ConnectionState.Open)
                {
                    _conexion.Close(); // Libera la conexión con SQL Server
                }
            }
            catch { }

            // Registro de cierre de temporada en archivo de log
            System.IO.File.AppendAllText(
                "log_temporada.txt",
                $"[{DateTime.Now:dd/MM/yyyy HH:mm}] Temporada {Anio} finalizada. " +
                $"Conexión cerrada y recursos liberados.{Environment.NewLine}"
            );
        }
    }
}