using System;
using LigaAccesoDatos;

namespace LogicaDeportiva
{
    public class Bateador : Jugadorr
    {
        public Bateador()
            : base()
        {
        }

        public Bateador(string nombre, string apellido, DateTime fechaNacimiento)
            : base(nombre, apellido, fechaNacimiento)
        {
        }

        public override double CalcularPromBate(EstadisticasOfensivas ofensiva)
        {
            if (ofensiva == null)
            {
                return 0;
            }

            if (ofensiva.Turnos_Al_Bate_AB <= 0)
            {
                return 0;
            }

            double promedio = (double)ofensiva.Hits_H / ofensiva.Turnos_Al_Bate_AB;

            return Math.Round(promedio, 3);
        }

        public override double CalcularERA(EstadisticasPitcheo pitcheo)
        {
            return 0;
        }

        public override string ObtenerInfo()
        {
            return $"BATEADOR → {Nombre} {Apellido} | Posición: {Posicion} | Batea: {Batea}";
        }
    }
}