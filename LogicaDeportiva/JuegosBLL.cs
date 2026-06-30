using LigaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaDeportiva
{
    public class JuegosBLL
    {
        private readonly JuegosDAL _dal = new JuegosDAL();

        // MÉTODO REGISTRAR
        public string Registrar(Juegos j)
        {
            if (j == null)
            {
                return "ERROR: El juego no puede estar vacío.";
            }

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

        // MÉTODO BUSCAR
        public List<Juegos> Buscar(string texto)
        {
            List<Juegos> lista = _dal.ObtenerTodos();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return lista;
            }

            texto = texto.Trim();

            return lista.Where(j =>
                j.Id_Juego.ToString().Contains(texto) ||
                j.Id_Equipo_Local.ToString().Contains(texto) ||
                j.Id_Equipo_Visitante.ToString().Contains(texto) ||
                j.Fecha_Juego.ToString("dd/MM/yyyy").Contains(texto) ||
                j.Carrera_Local.ToString().Contains(texto) ||
                j.Carrera_Visitante.ToString().Contains(texto) ||
                j.Estado_Juego.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();
        }

        // MÉTODO ELIMINAR
        public string Eliminar(int idJuego)
        {
            if (idJuego <= 0)
            {
                return "ERROR: Debe seleccionar un juego válido.";
            }

            bool ok = _dal.Eliminar(idJuego);

            return ok
                ? "OK: Juego eliminado exitosamente."
                : "ERROR: No se pudo eliminar el juego.";
        }

        // MÉTODO CALCULAR
        // Calcula el resultado del juego y muestra quién ganó.
        public string Calcular(Juegos j)
        {
            if (j == null)
            {
                return "ERROR: El juego no puede estar vacío.";
            }

            if (j.Carrera_Local < 0 || j.Carrera_Visitante < 0)
            {
                return "ERROR: Las carreras no pueden ser negativas.";
            }

            if (j.Carrera_Local > j.Carrera_Visitante)
            {
                int diferencia = j.Carrera_Local - j.Carrera_Visitante;

                return $"Ganó el equipo local por {diferencia} carrera(s).";
            }

            if (j.Carrera_Visitante > j.Carrera_Local)
            {
                int diferencia = j.Carrera_Visitante - j.Carrera_Local;

                return $"Ganó el equipo visitante por {diferencia} carrera(s).";
            }

            return "El juego terminó empatado.";
        }

        // MÉTODO OBTENER TODOS
        public List<Juegos> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}