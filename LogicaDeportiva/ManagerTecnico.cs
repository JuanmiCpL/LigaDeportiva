using LigaAccesoDatos;

namespace LigaAccesoDatos
{
    public class ManagerTecnico : Persona
    {
        public int Id_Manager { get; set; } = 0;
        public int Id_Equipo { get; set; } = 0;
        public int AniosExperiencia { get; set; } = 0;
        public string Especialidad { get; set; } = string.Empty;

        public ManagerTecnico(string nombre, string apellido, DateTime fechaNacimiento,
                              int idEquipo, int aniosExp, string especialidad)
            : base(nombre, apellido, fechaNacimiento)
        {
            Id_Equipo = idEquipo;
            AniosExperiencia = aniosExp;
            Especialidad = especialidad;
        }

        public ManagerTecnico() { }

        public override string Jugador()
        {
            return ($"nose");
        }

        public override string ManagerTecnicos()
        {
            return ($"Manager: {Nombre} {Apellido} | Exp.: {AniosExperiencia} años | {Especialidad}");
        }
    }
}