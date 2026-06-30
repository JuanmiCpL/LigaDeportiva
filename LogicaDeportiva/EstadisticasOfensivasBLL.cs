using LigaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaDeportiva
{
    public class EstadisticasOfensivasBLL
    {
        private readonly EstadisticasOfensivasDAL _dal = new EstadisticasOfensivasDAL();

        // MÉTODO REGISTRAR
        public string Registrar(EstadisticasOfensivas e)
        {
            if (e == null)
            {
                return "ERROR: La estadística ofensiva no puede estar vacía.";
            }

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

        // MÉTODO BUSCAR
        public List<EstadisticasOfensivas> Buscar(string texto)
        {
            List<EstadisticasOfensivas> lista = _dal.ObtenerTodos();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return lista;
            }

            texto = texto.Trim();

            return lista.Where(e =>
                e.Turnos_Al_Bate_AB.ToString().Contains(texto) ||
                e.Carreras_Anotadas_R.ToString().Contains(texto) ||
                e.Hits_H.ToString().Contains(texto) ||
                e.Dobles_2B.ToString().Contains(texto) ||
                e.Triples_3B.ToString().Contains(texto) ||
                e.Jonrones_HR.ToString().Contains(texto) ||
                e.Carreras_Empujadas_RBI.ToString().Contains(texto) ||
                e.Bases_Por_Bolas_BB.ToString().Contains(texto) ||
                e.Ponches_SO.ToString().Contains(texto) ||
                e.Bases_Robadas_SB.ToString().Contains(texto)
            ).ToList();
        }

        // MÉTODO ELIMINAR
        public string Eliminar(int idEstadisticaOfensiva)
        {
            if (idEstadisticaOfensiva <= 0)
            {
                return "ERROR: Debe seleccionar una estadística válida.";
            }

            bool ok = _dal.Eliminar(idEstadisticaOfensiva);

            return ok
                ? "OK: Estadística ofensiva eliminada exitosamente."
                : "ERROR: No se pudo eliminar la estadística ofensiva.";
        }

        // MÉTODO CALCULAR
        // Calcula el promedio de bateo: Hits / Turnos al bate
        public double Calcular(EstadisticasOfensivas e)
        {
            if (e == null)
            {
                return 0;
            }

            if (e.Turnos_Al_Bate_AB <= 0)
            {
                return 0;
            }

            double promedioBateo = (double)e.Hits_H / e.Turnos_Al_Bate_AB;

            return Math.Round(promedioBateo, 3);
        }

        // MÉTODO EXTRA PARA OBTENER TODOS
        public List<EstadisticasOfensivas> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
        // MÉTODO ACTUALIZAR
        public string Actualizar(EstadisticasOfensivas e)
        {
            if (e == null)
            {
                return "ERROR: La estadística ofensiva no puede estar vacía.";
            }

            if (e.Id_Estadisticas_Ofensivas <= 0)
            {
                return "ERROR: Debe seleccionar una estadística válida para actualizar.";
            }

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

            bool ok = _dal.Actualizar(e);

            return ok
                ? "OK: Estadística ofensiva actualizada exitosamente."
                : "ERROR: No se pudo actualizar la estadística ofensiva.";
        }
    }
}