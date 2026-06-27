using LigaAccesoDatos;   // accedemos a Estudiante y EstudianteDAL
using System.Collections.Generic;

namespace PB_Practica01.Negocios
{
    public class JuegosBLL
    {

        private readonly JuegosDAL _dal = new JuegosDAL();
        public string Registrar(Juegos e)
        {
            if (string.IsNullOrWhiteSpace(e.Estado_Juego))
            {
                return "ERROR: Todos los campos son obligatorios.";
            }

            bool ok = _dal.Insertar(e);
            return ok
                ? "OK: Estudiante registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }
        public List<Juegos> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}