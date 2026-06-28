using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAccesoDatos
{
    public class EstadisticasOfensivas
    {
        public int Id_Estadisticas_Ofensivas { get; set; } = 0;
        public int Id_Jugador { get; set; } = 0;
        public Jugadores Jugadores { get; set; }
        public int Id_Juego { get; set; } = 0;
        public Juegos Juegos { get; set; }
        public int Turnos_Al_Bate_AB { get; set; } = 0;
        public int Carreras_Anotadas_R { get; set; } = 0;
        public int Hits_H { get; set; } = 0;
        public int Dobles_2B { get; set; } = 0;
        public int Triples_3B { get; set; } = 0;
        public int Jonrones_HR { get; set; } = 0;
        public int Carreras_Empujadas_RBI { get; set; } = 0;
        public int Bases_Por_Bolas_BB { get; set; } = 0;
        public int Ponches_SO { get; set; } = 0;
        public int Bases_Robadas_SB { get; set; } = 0;
    }
}
