using Microsoft.Data.SqlClient;
using System.Collections.Generic;


namespace LigaAccesoDatos
{
    public class EstadisticasPitcheoDAL
    {
        // ── INSERTAR ─────────────────────────────────────────────────
        public bool Insertar(EstadisticasPitcheo E)
        {
            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(@"
                INSERT INTO EstadisticasPitcheo (Id_Jugador, Id_Juego, Entradas_Lanzadas_IP, Hits_Permitidos_H, Carreras_Permitidas_R, Carreras_Limpias_ER, Bases_Por_Bolas_Concedidas_BB, Ponches_Propinados_SO, Jonrones_Permitidos_HR, Ganado_w, Perdido_L, Salvado_SV)
                VALUES (@Id_Jugador, @Id_Juego, @Entradas_Lanzadas_IP, @Hits_Permitidos_H, @Carreras_Permitidas_R, @Carreras_Limpias_ER, @Bases_Por_Bolas_Concedidas_BB, @Ponches_Propinados_SO, @Jonrones_Permitidos_HR, @Ganado_w, @Perdido_L, @Salvado_SV)", con))
            {
                // Parámetros con @ evitan SQL Injection
                cmd.Parameters.AddWithValue("@Id_Jugador", E.Id_Jugador);
                cmd.Parameters.AddWithValue("@Id_Juego", E.Id_Juego);
                cmd.Parameters.AddWithValue("@Entradas_Lanzadas_IP", E.Entradas_Lanzadas_IP);
                cmd.Parameters.AddWithValue("@Hits_Permitidos_H", E.Hits_Permitidos_H);
                cmd.Parameters.AddWithValue("@Carreras_Permitidas_R", E.Carreras_Permitidas_R);
                cmd.Parameters.AddWithValue("@Carreras_Limpias_ER", E.Carreras_Limpias_ER);
                cmd.Parameters.AddWithValue("@Bases_Por_Bolas_Concedidas_BB", E.Bases_Por_Bolas_Concedidas_BB);
                cmd.Parameters.AddWithValue("@Ponches_Propinados_SO", E.Ponches_Propinados_SO);
                cmd.Parameters.AddWithValue("@Jonrones_Permitidos_HR", E.Jonrones_Permitidos_HR);
                cmd.Parameters.AddWithValue("@Ganado_w", E.Ganado_w);
                cmd.Parameters.AddWithValue("@Perdido_L", E.Ganado_w);
                cmd.Parameters.AddWithValue("@Salvado_SV", E.Salvado_SV);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;  // true = se insertó al menos 1 fila
            }
        }

        // ── LISTAR TODOS ──────────────────────────────────────────────
        public List<EstadisticasPitcheo> ObtenerTodos()
        {
            var lista = new List<EstadisticasPitcheo>();

            using (var con = ConexionDB.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "SELECT Id_Estadisticas_Pitcheo, Id_Jugador, Id_Juego, Entradas_Lanzadas_IP, Hits_Permitidos_H, Carreras_Permitidas_R, Carreras_Limpias_ER, Bases_Por_Bolas_Concedidas_BB, Ponches_Propinados_SO, Jonrones_Permitidos_HR, Ganado_w, Perdido_L, Salvado_SV", con))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new EstadisticasPitcheo
                    {
                        Id_Estadisticas_Pitcheo = reader.GetInt32(0),
                        Id_Jugador = reader.GetInt32(1),
                        Id_Juego = reader.GetInt32(2),
                        Entradas_Lanzadas_IP = reader.GetDouble(3),
                        Hits_Permitidos_H = reader.GetInt32(4),
                        Carreras_Permitidas_R = reader.GetInt32(5),
                        Carreras_Limpias_ER = reader.GetInt32(6),
                        Bases_Por_Bolas_Concedidas_BB = reader.GetInt32(7),
                        Ponches_Propinados_SO = reader.GetInt32(8),
                        Jonrones_Permitidos_HR = reader.GetInt32(9),
                        Ganado_w = reader.GetBoolean(10),
                        Perdido_L = reader.GetBoolean(11),
                        Salvado_SV = reader.GetBoolean(12)
                    });
                }
            }
            return lista;
        }
    }
}
