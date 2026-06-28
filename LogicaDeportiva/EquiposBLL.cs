using LigaAccesoDatos; // accedemos a Equipos y EquiposDAL
using System.Collections.Generic;

namespace LogicaDeportiva
{
    public class EquiposBLL
    {
        private readonly EquiposDAL _dal = new EquiposDAL();

        public string Registrar(Equipos e)
        {
            if (string.IsNullOrWhiteSpace(e.Nombre_Equipo) ||
                string.IsNullOrWhiteSpace(e.Ciudad) ||
                string.IsNullOrWhiteSpace(e.Estadio) ||
                string.IsNullOrWhiteSpace(e.Fecha_Fundacion) ||
                string.IsNullOrWhiteSpace(e.Nombre_Manager))
            {
                return "ERROR: Todos los campos son obligatorios.";
            }

            bool ok = _dal.Insertar(e);
            return ok
                ? "OK: Registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }

        public List<Equipos> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}