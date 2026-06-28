using LigaAccesoDatos; // accedemos a Jugadores y JugadoresDAL
using System.Collections.Generic;

namespace LogicaDeportiva
{
    public class JugadoresBLL
    {
        private readonly JugadoresDAL _dal = new JugadoresDAL();

        public string Registrar(Jugadores J)
        {
            // Validar ID del equipo (int, debe ser > 0)
            if (J.Id_Equipo <= 0)
            {
                return "ERROR: Debe seleccionar un equipo.";
            }

            // Validar strings obligatorios
            if (string.IsNullOrWhiteSpace(J.Nombre) ||
                string.IsNullOrWhiteSpace(J.Apellido) ||
                string.IsNullOrWhiteSpace(J.Posicion) ||
                string.IsNullOrWhiteSpace(J.Batea) ||
                string.IsNullOrWhiteSpace(J.Lanza) ||
                string.IsNullOrWhiteSpace(J.Fecha_Nacimiento))
            {
                return "ERROR: Todos los campos son obligatorios.";
            }

            // Validar número de camiseta (int, debe ser > 0)
            if (J.Numero_Camiseta <= 0)
            {
                return "ERROR: El número de camiseta debe ser mayor a 0.";
            }

            bool ok = _dal.Insertar(J);
            return ok
                ? "OK: Jugador registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }

        public List<Jugadores> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}