using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAccesoDatos
{
    public class Equipos
    {
        public int Id_Equipo { get; set; } = 0;
        public string Nombre_Equipo { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
        public string Estadio { get; set; } = string.Empty;
        public DateTime Fecha_Fundacion { get; set; }
        public string Nombre_Manager { get; set; } = string.Empty;
    }
}
