using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAccesoDatos
{
    public class EstadisticasPitcheo
    {
        public int Id_Estadisticas_Pitcheo { get; set; } = 0;
        public int Id_Jugador { get; set; } = 0;
        public Jugadores Jugadores { get; set; }
        public int Id_Juego { get; set; } = 0;
        public  Juegos Juegos { get; set; }
        public double Entradas_Lanzadas_IP { get; set; }
        public int Hits_Permitidos_H { get; set; } = 0;
        public int Carreras_Permitidas_R { get; set; } = 0;
        public int Carreras_Limpias_ER { get; set; } = 0;
        public int Bases_Por_Bolas_Concedidas_BB { get; set; } = 0;
        public int Ponches_Propinados_SO { get; set; } = 0;
        public int Jonrones_Permitidos_HR { get; set; } = 0;
        public bool Ganado_w { get; set; }
        public bool Perdido_L { get; set; }
        public bool Salvado_SV { get; set; }
    }
}
