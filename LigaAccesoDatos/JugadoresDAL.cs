using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace LigaAccesoDatos
{
    public class JugadoresDAL
    {
        // ── INSERTAR ─────────────────────────────────────────────────
        public bool Insertar(Jugadores j)
        {
            try
            {
                using (var con = ConexionDB.ObtenerConexion())
                using (var cmd = new SqlCommand(@"
            INSERT INTO Jugadores (Id_Equipo, Nombre, Apellido, Numero_Camiseta, Posicion, 
                                   Batea, Lanza, Fecha_Nacimiento, Nacionalidad, Altura, 
                                   Peso, Temporadas, Activo, Importado)
            VALUES (@Id_Equipo, @Nombre, @Apellido, @Numero_Camiseta, @Posicion, 
                    @Batea, @Lanza, @Fecha_Nacimiento, @Nacionalidad, @Altura, 
                    @Peso, @Temporadas, @Activo, @Importado)", con))
                {
                    cmd.Parameters.AddWithValue("@Id_Equipo", j.Id_Equipo);
                    cmd.Parameters.AddWithValue("@Nombre", j.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", j.Apellido);
                    cmd.Parameters.AddWithValue("@Numero_Camiseta", j.Numero_Camiseta);
                    cmd.Parameters.AddWithValue("@Posicion", j.Posicion);
                    cmd.Parameters.AddWithValue("@Batea", j.Batea);
                    cmd.Parameters.AddWithValue("@Lanza", j.Lanza);
                    cmd.Parameters.AddWithValue("@Fecha_Nacimiento", j.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@Nacionalidad", j.Nacionalidad);
                    cmd.Parameters.AddWithValue("@Altura", j.Altura);
                    cmd.Parameters.AddWithValue("@Peso", j.Peso);
                    cmd.Parameters.AddWithValue("@Temporadas", j.Temporadas);
                    cmd.Parameters.AddWithValue("@Activo", j.Activo);
                    cmd.Parameters.AddWithValue("@Importado", j.Importado);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar jugador: " + ex.Message);
                return false;
            }
        }

        // ── LISTAR TODOS ──────────────────────────────────────────────
        public List<Jugadores> ObtenerTodos()
        {
            var lista = new List<Jugadores>();

            try
            {
                using (var con = ConexionDB.ObtenerConexion())
                using (var cmd = new SqlCommand(@"
            SELECT Id_Jugador, Id_Equipo, Nombre, Apellido, Numero_Camiseta, 
                   Posicion, Batea, Lanza, Fecha_Nacimiento, Nacionalidad, 
                   Altura, Peso, Temporadas, Activo, Importado 
            FROM Jugadores", con))
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
                            Fecha_Nacimiento = reader.GetDateTime(8),
                            Nacionalidad = reader.IsDBNull(9) ? "" : reader.GetString(9),
                            Altura = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10),
                            Peso = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11),
                            Temporadas = reader.IsDBNull(12) ? 0 : reader.GetInt32(12),
                            Activo = reader.IsDBNull(13) ? false : reader.GetBoolean(13),
                            Importado = reader.IsDBNull(14) ? false : reader.GetBoolean(14)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener jugadores: " + ex.Message);
            }

            return lista;
        }
        // ── ELIMINAR ─────────────────────────────────────────────────
        public bool Eliminar(int idJugador)
        {
            try
            {
                using (var con = ConexionDB.ObtenerConexion())
                using (var cmd = new SqlCommand(@"
                DELETE FROM Jugadores 
                WHERE Id_Jugador = @Id_Jugador", con))
                {
                    cmd.Parameters.AddWithValue("@Id_Jugador", idJugador);

                    int filas = cmd.ExecuteNonQuery();

                    return filas > 0;

                }
            }
                 catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar estadística ofensiva: " + ex.Message);
                return false;
            }
        }
    }
}