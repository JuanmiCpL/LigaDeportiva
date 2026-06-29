using LigaAccesoDatos;
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
                string.IsNullOrWhiteSpace(e.Nombre_Manager))
            {
                return "ERROR: Todos los campos son obligatorios.";
            }
            if (e.Fecha_Fundacion == DateTime.MinValue)
            {
                Console.WriteLine("La fecha de fundación es obligatoria");
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
        public List<Equipos> Buscar(string texto)
        {
            List<Equipos> lista = _dal.ObtenerTodos();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return lista;
            }

            texto = texto.Trim();

            return lista.Where(e =>
                e.Nombre_Equipo.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                e.Ciudad.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                e.Estadio.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                e.Nombre_Manager.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();
        }

    }
}