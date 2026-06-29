using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LigaAccesoDatos
{
    public class Jugadores
    {
        public int Id_Jugador { get; set; } = 0;
        public int Id_Equipo { get; set; } = 0;
        public Equipos Equipos { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int Numero_Camiseta { get; set; } = 0;
        public string Posicion { get; set; } = string.Empty;
        public string Batea { get; set; } = string.Empty;
        public string Lanza { get; set; } = string.Empty;
        public DateTime Fecha_Nacimiento { get; set; } = DateTime.Now;

    }
}