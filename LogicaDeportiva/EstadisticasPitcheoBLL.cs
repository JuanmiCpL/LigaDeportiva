using LigaAccesoDatos; 
using System.Collections.Generic;

namespace LogicaDeportiva
{
    public class EstadisticasPitcheoBLL
    {
        private readonly EstadisticasPitcheoDAL _dal = new EstadisticasPitcheoDAL();

        public string Registrar(EstadisticasPitcheo E)
        {
            if (E.Entradas_Lanzadas_IP <= 0)
            {
                return "ERROR: Las entradas lanzadas son obligatorias y deben ser mayor a 0.";
            }

            if (E.Hits_Permitidos_H < 0 ||
                E.Carreras_Permitidas_R < 0 ||
                E.Carreras_Limpias_ER < 0 ||
                E.Bases_Por_Bolas_Concedidas_BB < 0 ||
                E.Ponches_Propinados_SO < 0 ||
                E.Jonrones_Permitidos_HR < 0)
            {
                return "ERROR: Los valores estadísticos no pueden ser negativos.";
            }


            bool ok = _dal.Insertar(E);
            return ok
                ? "OK: Registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }

        public List<EstadisticasPitcheo> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}