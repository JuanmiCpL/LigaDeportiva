using LigaAccesoDatos;
using System.Collections.Generic;
using System;

namespace LogicaDeportiva
{
    public class JuegosBLL
    {
        private readonly JuegosDAL _dal = new JuegosDAL();

        public string Registrar(Juegos j)
        {
            if (j.Id_Equipo_Local <= 0 || j.Id_Equipo_Visitante <= 0)
            {
                return "ERROR: Debe seleccionar el equipo local y visitante.";
            }

            if (j.Id_Equipo_Local == j.Id_Equipo_Visitante)
            {
                return "ERROR: El equipo local y visitante no pueden ser el mismo.";
            }

            if (j.Fecha_Juego == default(DateTime))
            {
                return "ERROR: La fecha del juego es obligatoria.";
            }

            if (j.Carrera_Local < 0 || j.Carrera_Visitante < 0)
            {
                return "ERROR: Las carreras no pueden ser negativas.";
            }

            if (string.IsNullOrWhiteSpace(j.Estado_Juego))
            {
                return "ERROR: El estado del juego es obligatorio.";
            }

            bool ok = _dal.Insertar(j);
            return ok
                ? "OK: Juego registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }

        public List<Juegos> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}