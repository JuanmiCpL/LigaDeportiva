using Microsoft.Data.SqlClient;
using System.Collections.Generic;


namespace LigaAccesoDatos
{
    public class JugadoresDAL
    {
        // ── INSERTAR ─────────────────────────────────────────────────
        public bool Insertar(Jugadores j)
        {
            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(@"
                INSERT INTO Jugadores (Id_Equipo, Nombre, Apellido, Numero_Camiseta, Posicion, Batea, Lanza, Fecha_Nacimineto)
                VALUES (@Id_Equipo, @Nombre, @Apellido, @Numero_Camiseta, @Posicion, @Batea, @Lanza, @Fecha_Nacimineto)", con))
            {
                // Parámetros con @ evitan SQL Injection
                cmd.Parameters.AddWithValue("@Id_Equipo", j.Id_Equipo);
                cmd.Parameters.AddWithValue("@Nombre", j.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", j.Apellido);
                cmd.Parameters.AddWithValue("@Numero_Camiseta", j.Numero_Camiseta);
                cmd.Parameters.AddWithValue("@Posicion", j.Posicion);
                cmd.Parameters.AddWithValue("@Batea", j.Batea);
                cmd.Parameters.AddWithValue("@Lanza", j.Lanza);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", j.Fecha_Nacimiento);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;  // true = se insertó al menos 1 fila
            }
        }

        // ── LISTAR TODOS ──────────────────────────────────────────────
        public List<Jugadores> ObtenerTodos()
        {
            var lista = new List<Jugadores>();

            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "SELECT Id_Jugador, Id_Equipo, Nombre, Apellido, Numero_Camiseta, Posicion, Batea, Lanza, Fecha_Nacimineto", con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Jugadores
                    {
                        Id_Jugador = reader.GetInt32(0),
                        Id_Equipo = reader.GetInt32(1),
                        Nombre = reader.GetString(2),
                        Apellido = reader.GetString(3),
                        Numero_Camiseta = reader.GetInt32(4),
                        Posicion = reader.GetString(5),
                        Batea = reader.GetString(6),
                        Lanza = reader.GetString(7),
                        Fecha_Nacimiento = reader.GetString(8)
                    });
                }
            }
            return lista;
        }
    }
}
