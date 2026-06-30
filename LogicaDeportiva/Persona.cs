using System;
using LigaAccesoDatos;

namespace LogicaDeportiva
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Fecha_Nacimiento = DateTime.Now;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Fecha_Nacimiento = fechaNacimiento;
        }

        public abstract string Jugador();
        public abstract string ManagerTecnicos();
        public abstract string ObtenerInfo();

        // MÉTODO VIRTUAL PARA PROMEDIO DE BATEO
        public virtual double CalcularPromBate(EstadisticasOfensivas ofensiva)
        {
            return 0;
        }

        // MÉTODO VIRTUAL PARA ERA
        public virtual double CalcularERA(EstadisticasPitcheo pitcheo)
        {
            return 0;
        }
    }
}