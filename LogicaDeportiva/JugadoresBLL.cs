using LigaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaDeportiva
{
    public class JugadoresBLL
    {
        private readonly JugadoresDAL _dal = new JugadoresDAL();

        // MÉTODO REGISTRAR
        public string Registrar(Jugadores J)
        {
            if (J == null)
            {
                return "ERROR: El jugador no puede estar vacío.";
            }

            if (J.Id_Equipo <= 0)
                return "ERROR: Debe seleccionar un equipo.";

            if (string.IsNullOrWhiteSpace(J.Nombre) ||
                string.IsNullOrWhiteSpace(J.Apellido) ||
                string.IsNullOrWhiteSpace(J.Posicion) ||
                string.IsNullOrWhiteSpace(J.Batea) ||
                string.IsNullOrWhiteSpace(J.Lanza))
                return "ERROR: Todos los campos son obligatorios.";

            if (J.Fecha_Nacimiento == DateTime.MinValue)
                return "ERROR: La fecha de nacimiento es obligatoria.";

            if (J.Fecha_Nacimiento > DateTime.Now)
                return "ERROR: La fecha de nacimiento no puede ser futura.";

            if (J.Numero_Camiseta <= 0)
                return "ERROR: El número de camiseta debe ser mayor a 0.";

            bool ok = _dal.Insertar(J);

            return ok
                ? "OK: Jugador registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }

        // MÉTODO BUSCAR
        public List<Jugadores> Buscar(string texto)
        {
            List<Jugadores> lista = _dal.ObtenerTodos();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return lista;
            }

            texto = texto.Trim();

            return lista.Where(J =>
                J.Id_Jugador.ToString().Contains(texto) ||
                J.Id_Equipo.ToString().Contains(texto) ||
                J.Numero_Camiseta.ToString().Contains(texto) ||
                J.Nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                J.Apellido.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                J.Posicion.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                J.Batea.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                J.Lanza.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                J.Fecha_Nacimiento.ToString("dd/MM/yyyy").Contains(texto)
            ).ToList();
        }

        // MÉTODO ELIMINAR
        public string Eliminar(int idJugador)
        {
            if (idJugador <= 0)
            {
                return "ERROR: Debe seleccionar un jugador válido.";
            }

            bool ok = _dal.Eliminar(idJugador);

            return ok
                ? "OK: Jugador eliminado exitosamente."
                : "ERROR: No se pudo eliminar el jugador.";
        }

        // MÉTODO CALCULAR
        // Calcula la edad del jugador usando la fecha de nacimiento.
        public int Calcular(Jugadores J)
        {
            if (J == null)
            {
                return 0;
            }

            if (J.Fecha_Nacimiento == DateTime.MinValue)
            {
                return 0;
            }

            int edad = DateTime.Now.Year - J.Fecha_Nacimiento.Year;

            if (DateTime.Now < J.Fecha_Nacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        // MÉTODO OBTENER TODOS
        public List<Jugadores> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        // MÉTODO PARA USAR POLIMORFISMO CON PERSONA
        public string ObtenerInfoPersona(Persona p)
        {
            if (p == null)
            {
                return "ERROR: La persona no puede estar vacía.";
            }

            return p.ObtenerInfo();
        }
    }
}