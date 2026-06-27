using LigaAccesoDatos;   // accedemos a Estudiante y EstudianteDAL
using System.Collections.Generic;

namespace PB_Practica01.Negocios
{
    public class JugadoresBLL
    {

        private readonly JugadoresDAL _dal = new JugadoresDAL();
        public string Registrar(Jugadores e)
        {
            if (string.IsNullOrWhiteSpace(e.Nombre) ||
                string.IsNullOrWhiteSpace(e.Apellido) ||
                string.IsNullOrWhiteSpace(e.Posicion) ||
                string.IsNullOrWhiteSpace(e.Batea)||
                string.IsNullOrWhiteSpace(e.Lanza))
            {
                return "ERROR: Todos los campos son obligatorios.";
            }

            bool ok = _dal.Insertar(e);
            return ok
                ? "OK: Estudiante registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }
        public List<Jugadores> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}