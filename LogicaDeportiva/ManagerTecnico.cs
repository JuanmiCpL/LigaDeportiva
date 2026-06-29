using System;

namespace LigaAccesoDatos
{
    public class ManagerTecnico : Persona
    {
        public int Id_Equipo { get; set; } = 0;

        public ManagerTecnico(string nombre, string apellido, DateTime fechaNacimiento, int idEquipo)
            : base(nombre, apellido, fechaNacimiento)
        {
            Id_Equipo = idEquipo;
        }

        public ManagerTecnico() { }

        public override string Jugador()
        {
            return "No aplica para managers.";
        }

        public override string ManagerTecnicos()
        {
            return $"Manager: {Nombre} {Apellido}";
        }

        public override string ObtenerInfo()
        {
            return $"MANAGER → {Nombre} {Apellido} | Fecha Nac.: {Fecha_Nacimiento:dd/MM/yyyy}";
        }
    }
}