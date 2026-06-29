using System;

namespace LigaAccesoDatos
{
    public class Jugadorr : Persona
    {
        public Jugadorr(string nombre, string apellido, DateTime fechaNacimiento)
            : base(nombre, apellido, fechaNacimiento)
        {
        }


        public Jugadorr() { }

        public override string Jugador()
        {
            return $"Jugador: {Nombre} {Apellido} | Fecha Nac.: {Fecha_Nacimiento:dd/MM/yyyy}";
        }

        public override string ManagerTecnicos()
        {
            return "No aplica para jugadores.";
        }
        public override string ObtenerInfo()
        {
            return $"JUGADOR → {Nombre} {Apellido} | Fecha Nac.: {Fecha_Nacimiento:dd/MM/yyyy}";
        }
    }
}