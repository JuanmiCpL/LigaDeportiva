using System;
using LigaAccesoDatos;

namespace LogicaDeportiva
{
    public class Lanzador : Jugadorr
    {
        public Lanzador()
            : base()
        {
        }

        public Lanzador(string nombre, string apellido, DateTime fechaNacimiento)
            : base(nombre, apellido, fechaNacimiento)
        {
        }

        public override double CalcularERA(EstadisticasPitcheo pitcheo)
        {
            if (pitcheo == null)
            {
                return 0;
            }

            if (pitcheo.Entradas_Lanzadas_IP <= 0)
            {
                return 0;
            }

            double era = (pitcheo.Carreras_Limpias_ER * 9.0) / pitcheo.Entradas_Lanzadas_IP;

            return Math.Round(era, 2);
        }

        public override double CalcularPromBate(EstadisticasOfensivas ofensiva)
        {
            return 0;
        }

        public override string ObtenerInfo()
        {
            return $"LANZADOR → {Nombre} {Apellido} | Posición: {Posicion} | Lanza: {Lanza}";
        }
    }
}