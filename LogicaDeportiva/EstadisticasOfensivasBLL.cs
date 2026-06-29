using LigaAccesoDatos; 
using System.Collections.Generic;

namespace LogicaDeportiva
{
    public class EstadisticasOfensivasBLL
    {
        private readonly EstadisticasOfensivasDAL _dal = new EstadisticasOfensivasDAL();

        public string Registrar(EstadisticasOfensivas e)
        {
            if (e.Turnos_Al_Bate_AB <= 0)
            {
                return "ERROR: Los turnos al bate son obligatorios y deben ser mayor a 0.";
            }
            if (e.Carreras_Anotadas_R < 0 ||
                e.Hits_H < 0 ||
                e.Dobles_2B < 0 ||
                e.Triples_3B < 0 ||
                e.Jonrones_HR < 0 ||
                e.Carreras_Empujadas_RBI < 0 ||
                e.Bases_Por_Bolas_BB < 0 ||
                e.Ponches_SO < 0 ||
                e.Bases_Robadas_SB < 0)
            {
                return "ERROR: Los valores estadísticos no pueden ser negativos.";
            }

            bool ok = _dal.Insertar(e);
            return ok
                ? "OK: Registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }

        public List<EstadisticasOfensivas> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
    }
}