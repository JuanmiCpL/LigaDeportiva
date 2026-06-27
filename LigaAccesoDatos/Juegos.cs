using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAccesoDatos
{
    public class Juegos
    {
        public int Id_Juego { get; set; }
        public int Id_Equipo_Local { get; set; }
        public int Id_Equipo_Visitante { get; set; }
        public DateTime Fecha_Juego { get; set; }
        public int Carrera_Local { get; set; }
        public int Carrera_Visitante { get; set; }
        public string Estado_Juego { get; set; } = string.Empty;
    }
}
