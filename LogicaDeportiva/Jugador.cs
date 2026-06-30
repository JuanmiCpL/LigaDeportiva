using System;

namespace LogicaDeportiva
{
    public class Jugadorr : Persona
    {
        public int Id_Jugador { get; set; } = 0;
        public int Id_Equipo { get; set; } = 0;
        public Equipos Equipos { get; set; }
        public int Numero_Camiseta { get; set; } = 0;
        public string Posicion { get; set; } = string.Empty;
        public string Batea { get; set; } = string.Empty;
        public string Lanza { get; set; } = string.Empty;

        public Jugadorr()
            : base()
        {
        }

        public Jugadorr(string nombre, string apellido, DateTime fechaNacimiento)
            : base(nombre, apellido, fechaNacimiento)
        {
        }

        public Jugadorr(
            int idJugador,
            int idEquipo,
            Equipos equipos,
            string nombre,
            string apellido,
            int numeroCamiseta,
            string posicion,
            string batea,
            string lanza,
            DateTime fechaNacimiento)
            : base(nombre, apellido, fechaNacimiento)
        {
            Id_Jugador = idJugador;
            Id_Equipo = idEquipo;
            Equipos = equipos;
            Numero_Camiseta = numeroCamiseta;
            Posicion = posicion;
            Batea = batea;
            Lanza = lanza;
        }

        public override string Jugador()
        {
            return $"Jugador: {Nombre} {Apellido} | Posición: {Posicion}";
        }

        public override string ManagerTecnicos()
        {
            return "No aplica para jugadores.";
        }

        public override string ObtenerInfo()
        {
            return $"JUGADOR → {Nombre} {Apellido} | Posición: {Posicion} | Camiseta: {Numero_Camiseta}";
        }
    }
}