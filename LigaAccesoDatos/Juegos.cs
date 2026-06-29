using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAccesoDatos
{
    public class Juegos
    {
        public int Id_Juego { get; set; } = 0;
        public int Id_Equipo_Local { get; set; } = 0;
        public int Id_Equipo_Visitante { get; set; } = 0;
        public Equipos EquipoLocal { get; set; }
        public Equipos EquipoVisitante { get; set; }
        public DateTime Fecha_Juego { get; set; }
        public int Carrera_Local { get; set; } = 0;
        public int Carrera_Visitante { get; set; } = 0;
        public string Estado_Juego { get; set; } = string.Empty;
    }
}
