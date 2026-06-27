using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAccesoDatos
{
    public class EstadisticasOfensivas
    {
        public int Id_Estadisticas_Ofensivas { get; set; }
        public int Id_Jugador { get; set; }
        public int Id_Juego { get; set; }
        public Juegos Juegos { get; set; }
        public int Turnos_Al_Bate_AB { get; set; }
        public int Carreras_Anotadas_R { get; set; }
        public int Hits_H { get; set; }
        public int Dobles_2B { get; set; }
        public int Triples_3B { get; set; }
        public int Jonrones_HR { get; set; }
        public int Carreras_Empujadas_RBI { get; set; }
        public int Bases_Por_Bolas_BB { get; set; }
        public int Ponches_SO { get; set; }
        public int Bases_Robadas_SB { get; set; }
    }
}
