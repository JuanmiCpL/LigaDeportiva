using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAccesoDatos
{
    public class Jugadores
    {
        public int Id_Jugador { get; set; }
        public int Id_Equipo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int Numero_Camiseta { get; set; }
        public string Posicion { get; set; } = string.Empty;
        public string Batea { get; set; } = string.Empty;
        public string Lanza { get; set; } = string.Empty;
        public string Fecha_Nacimiento { get; set; } = string.Empty;
    }
}
