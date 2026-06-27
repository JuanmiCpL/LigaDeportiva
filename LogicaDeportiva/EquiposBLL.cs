using LigaAccesoDatos;   // accedemos a Estudiante y EstudianteDAL
using System.Collections.Generic;

namespace PB_Practica01.Negocios
{
    public class EquiposBLL
    {

        private readonly EquiposDAL _dal = new EquiposDAL();
        public string Registrar(Equipos e)
        {
            if (string.IsNullOrWhiteSpace(e.Nombre_Equipo) ||
                string.IsNullOrWhiteSpace(e.Ciudad) ||
                string.IsNullOrWhiteSpace(e.Estadio) ||
                string.IsNullOrWhiteSpace(e.Nombre_Manager))
            {
                return "ERROR: Todos los campos son obligatorios.";
            }

            bool ok = _dal.Insertar(e);
            return ok
                ? "OK: Estudiante registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }
        public List<Equipos> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}