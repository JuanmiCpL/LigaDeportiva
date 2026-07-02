using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System;
namespace LigaAccesoDatos
{
    public class EquiposDAL
    {
        // ── INSERTAR ─────────────────────────────────────────────────
        
        public bool Insertar(Equipos e)
        {
            try
            {
                using (var con = ConexionDB.ObtenerConexion())
                using (var cmd = new SqlCommand(@"
                INSERT INTO Equipos (Nombre_Equipo, Ciudad, Estadio, Fecha_Fundacion, Nombre_Manager)
                VALUES (@Nombre_Equipo, @Ciudad, @Estadio, @Fecha_Fundacion, @Nombre_Manager)", con))
                {
                    // Parámetros con @ evitan SQL Injection
                    cmd.Parameters.AddWithValue("@Nombre_Equipo", e.Nombre_Equipo);
                    cmd.Parameters.AddWithValue("@Ciudad", e.Ciudad);
                    cmd.Parameters.AddWithValue("@Estadio", e.Estadio);
                    cmd.Parameters.AddWithValue("@Fecha_Fundacion", e.Fecha_Fundacion);
                    cmd.Parameters.AddWithValue("@Nombre_Manager", e.Nombre_Manager);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }// true = se insertó al menos 1 fila
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar Equipos: " + ex.Message);
                return false;
            }
        }

        // ── LISTAR TODOS ──────────────────────────────────────────────
        public List<Equipos> ObtenerTodos()
        {
            var lista = new List<Equipos>();

            try
            {
                using (var con = ConexionDB.ObtenerConexion())
                using (var cmd = new SqlCommand(
                    "SELECT Id_Equipo, Nombre_Equipo, Ciudad, Estadio, Fecha_Fundacion, Nombre_Manager FROM Equipos", con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Equipos
                        {
                            Id_Equipo = reader.GetInt32(0),
                            Nombre_Equipo = reader.GetString(1),
                            Ciudad = reader.GetString(2),
                            Estadio = reader.GetString(3),
                            Fecha_Fundacion = reader.GetDateTime(4),
                            Nombre_Manager = reader.GetString(5)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener equipos: " + ex.Message);
            }

            return lista;
        }
        public bool Eliminar(int idEquipo)
        {
            try
            {
                using (var con = ConexionDB.ObtenerConexion())
                using (var cmd = new SqlCommand("DELETE FROM Equipos WHERE Id_Equipo = @Id_Equipo", con))
                {
                    cmd.Parameters.AddWithValue("@Id_Equipo", idEquipo);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar equipo: " + ex.Message);
                return false;
            }
        }
    }
}