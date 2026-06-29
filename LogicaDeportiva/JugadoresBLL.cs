using LigaAccesoDatos; 
using System.Collections.Generic;

namespace LogicaDeportiva
{
    public class JugadoresBLL
    {
        private readonly JugadoresDAL _dal = new JugadoresDAL();

        public string Registrar(Jugadores J)
        {
            if (J.Id_Equipo <= 0)
            {
                return "ERROR: Debe seleccionar un equipo.";
            }

            if (string.IsNullOrWhiteSpace(J.Nombre) ||
                string.IsNullOrWhiteSpace(J.Apellido) ||
                string.IsNullOrWhiteSpace(J.Posicion) ||
                string.IsNullOrWhiteSpace(J.Batea) ||
                string.IsNullOrWhiteSpace(J.Lanza))
            {
                return "ERROR: Todos los campos son obligatorios.";
            }
            if (J.Fecha_Nacimiento == DateTime.MinValue)
            {
                Console.WriteLine("La fecha de nacimeinto es obligatoria");
            }

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