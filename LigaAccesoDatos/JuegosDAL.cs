using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace LigaAccesoDatos
{
    public class JuegosDAL
    {
        // ── INSERTAR ─────────────────────────────────────────────────
        public bool Insertar(Juegos j)
        {
            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(@"
                INSERT INTO Juegos 
                (Id_Equipo_Local, Id_Equipo_Visitante, Fecha_Juego, Carrera_Local, Carrera_Visitante, Estado_Juego)
                VALUES 
                (@Id_Equipo_Local, @Id_Equipo_Visitante, @Fecha_Juego, @Carrera_Local, @Carrera_Visitante, @Estado_Juego)", con))
            {
                // Parámetros con @ evitan SQL Injection
                cmd.Parameters.AddWithValue("@Id_Equipo_Local", j.Id_Equipo_Local);
                cmd.Parameters.AddWithValue("@Id_Equipo_Visitante", j.Id_Equipo_Visitante);
                cmd.Parameters.AddWithValue("@Fecha_Juego", j.Fecha_Juego);
                cmd.Parameters.AddWithValue("@Carrera_Local", j.Carrera_Local);
                cmd.Parameters.AddWithValue("@Carrera_Visitante", j.Carrera_Visitante);
                cmd.Parameters.AddWithValue("@Estado_Juego", j.Estado_Juego);

                int filas = cmd.ExecuteNonQuery();

                return filas > 0;
            }
        }

        // ── LISTAR TODOS ──────────────────────────────────────────────
        public List<Juegos> ObtenerTodos()
        {
            var lista = new List<Juegos>();

            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(@"
                SELECT 
                    Id_Juego, 
                    Id_Equipo_Local, 
                    Id_Equipo_Visitante, 
                    Fecha_Juego, 
                    Carrera_Local, 
                    Carrera_Visitante, 
                    Estado_Juego 
                FROM Juegos", con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Juegos
                    {
                        Id_Juego = reader.GetInt32(0),
                        Id_Equipo_Local = reader.GetInt32(1),
                        Id_Equipo_Visitante = reader.GetInt32(2),
                        Fecha_Juego = reader.GetDateTime(3),
                        Carrera_Local = reader.GetInt32(4),
                        Carrera_Visitante = reader.GetInt32(5),
                        Estado_Juego = reader.GetString(6)
                    });
                }
            }

            return lista;
        }

        // ── ELIMINAR ─────────────────────────────────────────────────
        public bool Eliminar(int idJuego)
        {
            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(@"
                DELETE FROM Juegos 
                WHERE Id_Juego = @Id_Juego", con))
            {
                cmd.Parameters.AddWithValue("@Id_Juego", idJuego);

                int filas = cmd.ExecuteNonQuery();

                return filas > 0;
            }
        }
    }
}