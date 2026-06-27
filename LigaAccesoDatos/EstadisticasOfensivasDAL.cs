using Microsoft.Data.SqlClient;
using System.Collections.Generic;


namespace LigaAccesoDatos
{
    public class EstadisticasOfensivasDAL
    {
        // ── INSERTAR ─────────────────────────────────────────────────
        public bool Insertar(EstadisticasOfensivas E)
        {
            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(@"
                INSERT INTO EstadisticasOfensivas (Id_Jugador, Id_Juego, Turnos_Al_Bate_AB, Carreras_Anotadas_R, Hits_H, Dobles_2B, Triples_3B, Jonrones_HR, Carreras_Empujadas_RBI, Bases_Por_Bolas_BB, Ponches_SO, Bases_Robadas_SB)
                VALUES (@Id_Jugador, @Id_Juego, @Turnos_Al_Bate_AB, @Carreras_Anotadas_R, @Hits_H, @Dobles_2B, @Triples_3B, @Jonrones_HR, @Carreras_Empujadas_RBI, @Bases_Por_Bolas_BB, @Ponches_SO, @Bases_Robadas_SB)", con))
            {
                // Parámetros con @ evitan SQL Injection
                cmd.Parameters.AddWithValue("@Id_Jugador", E.Id_Jugador);
                cmd.Parameters.AddWithValue("@Id_Juego", E.Id_Juego);
                cmd.Parameters.AddWithValue("@Turnos_Al_Bate_AB", E.Turnos_Al_Bate_AB);
                cmd.Parameters.AddWithValue("@Carreras_Anotadas_R", E.Carreras_Anotadas_R);
                cmd.Parameters.AddWithValue("@Hits_H", E.Hits_H);
                cmd.Parameters.AddWithValue("@Dobles_2B", E.Dobles_2B);
                cmd.Parameters.AddWithValue("@Triples_3B", E.Triples_3B);
                cmd.Parameters.AddWithValue("@Jonrones_HR", E.Jonrones_HR);
                cmd.Parameters.AddWithValue("@Carreras_Empujadas_RBI", E.Carreras_Empujadas_RBI);
                cmd.Parameters.AddWithValue("@Bases_Por_Bolas_BB", E.Bases_Por_Bolas_BB);
                cmd.Parameters.AddWithValue("@Ponches_SO", E.Ponches_SO);
                cmd.Parameters.AddWithValue("@Bases_Robadas_SB", E.Bases_Robadas_SB);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;  // true = se insertó al menos 1 fila
            }
        }

        // ── LISTAR TODOS ──────────────────────────────────────────────
        public List<EstadisticasOfensivas> ObtenerTodos()
        {
            var lista = new List<EstadisticasOfensivas>();

            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "SELECT Id_Estadisticas_Ofensivas, Id_Jugador, Id_Juego, Turnos_Al_Bate_AB, Carreras_Anotadas_R, Hits_H, Dobles_2B, Triples_3B, Jonrones_HR, Carreras_Empujadas_RBI, Bases_Por_Bolas_BB, Ponches_SO, Bases_Robadas_SB", con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new EstadisticasOfensivas
                    {
                        Id_Estadisticas_Ofensivas = reader.GetInt32(0),
                        Id_Jugador = reader.GetInt32(1),
                        Id_Juego = reader.GetInt32(2),
                        Turnos_Al_Bate_AB = reader.GetInt32(3),
                        Carreras_Anotadas_R = reader.GetInt32(4),
                        Hits_H = reader.GetInt32(5),
                        Dobles_2B = reader.GetInt32(6),
                        Triples_3B = reader.GetInt32(7),
                        Jonrones_HR = reader.GetInt32(8),
                        Carreras_Empujadas_RBI = reader.GetInt32(9),
                        Bases_Por_Bolas_BB = reader.GetInt32(10),
                        Ponches_SO = reader.GetInt32(11),
                        Bases_Robadas_SB = reader.GetInt32(12)
                    });
                }
            }
            return lista; 
        }
    }
}
