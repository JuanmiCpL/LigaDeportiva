using LigaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaDeportiva
{
    public class EstadisticasPitcheoBLL
    {
        private readonly EstadisticasPitcheoDAL _dal = new EstadisticasPitcheoDAL();

        // MÉTODO REGISTRAR
        public string Registrar(EstadisticasPitcheo E)
        {
            if (E == null)
            {
                return "ERROR: La estadística de pitcheo no puede estar vacía.";
            }

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

            if (E.Ganado_w && E.Perdido_L)
            {
                return "ERROR: Un pitcher no puede tener juego ganado y perdido al mismo tiempo.";
            }

            if (E.Salvado_SV && (E.Ganado_w || E.Perdido_L))
            {
                return "ERROR: Si el pitcher tiene salvado, no debe marcarse como ganador ni perdedor.";
            }

            bool ok = _dal.Insertar(E);

            return ok
                ? "OK: Registrado exitosamente."
                : "ERROR: No se pudo guardar en la base de datos.";
        }

        // MÉTODO BUSCAR
        public List<EstadisticasPitcheo> Buscar(string texto)
        {
            List<EstadisticasPitcheo> lista = _dal.ObtenerTodos();

            if (string.IsNullOrWhiteSpace(texto))
            {
                return lista;
            }

            texto = texto.Trim();

            return lista.Where(E =>
                E.Id_Estadisticas_Pitcheo.ToString().Contains(texto) ||
                E.Id_Jugador.ToString().Contains(texto) ||
                E.Id_Juego.ToString().Contains(texto) ||
                E.Entradas_Lanzadas_IP.ToString().Contains(texto) ||
                E.Hits_Permitidos_H.ToString().Contains(texto) ||
                E.Carreras_Permitidas_R.ToString().Contains(texto) ||
                E.Carreras_Limpias_ER.ToString().Contains(texto) ||
                E.Bases_Por_Bolas_Concedidas_BB.ToString().Contains(texto) ||
                E.Ponches_Propinados_SO.ToString().Contains(texto) ||
                E.Jonrones_Permitidos_HR.ToString().Contains(texto) ||
                (E.Ganado_w ? "ganado victoria win w" : "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                (E.Perdido_L ? "perdido derrota loss l" : "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                (E.Salvado_SV ? "salvado save sv" : "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();
        }

        // MÉTODO ELIMINAR
        public string Eliminar(int idEstadisticaPitcheo)
        {
            if (idEstadisticaPitcheo <= 0)
            {
                return "ERROR: Debe seleccionar una estadística de pitcheo válida.";
            }

            bool ok = _dal.Eliminar(idEstadisticaPitcheo);

            return ok
                ? "OK: Estadística de pitcheo eliminada exitosamente."
                : "ERROR: No se pudo eliminar la estadística de pitcheo.";
        }

        // MÉTODO CALCULAR
        // Calcula el ERA y también muestra la decisión del pitcher.
        public string Calcular(EstadisticasPitcheo E)
        {
            if (E == null)
            {
                return "ERROR: La estadística de pitcheo no puede estar vacía.";
            }

            if (E.Entradas_Lanzadas_IP <= 0)
            {
                return "ERROR: Las entradas lanzadas deben ser mayor a 0.";
            }

            double era = (E.Carreras_Limpias_ER * 9.0) / E.Entradas_Lanzadas_IP;
            era = Math.Round(era, 2);

            string decision = "Sin decisión";

            if (E.Ganado_w)
            {
                decision = "Juego ganado";
            }
            else if (E.Perdido_L)
            {
                decision = "Juego perdido";
            }
            else if (E.Salvado_SV)
            {
                decision = "Juego salvado";
            }

            return $"ERA: {era} | Decisión: {decision}";
        }

        // MÉTODO OBTENER TODOS
        public List<EstadisticasPitcheo> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }
        // MÉTODO ACTUALIZAR
        public string Actualizar(EstadisticasPitcheo E)
        {
            if (E == null)
            {
                return "ERROR: La estadística de pitcheo no puede estar vacía.";
            }

            if (E.Id_Estadisticas_Pitcheo <= 0)
            {
                return "ERROR: Debe seleccionar una estadística válida para actualizar.";
            }

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

            if (E.Ganado_w && E.Perdido_L)
            {
                return "ERROR: Un pitcher no puede tener juego ganado y perdido al mismo tiempo.";
            }

            if (E.Salvado_SV && (E.Ganado_w || E.Perdido_L))
            {
                return "ERROR: Si el pitcher tiene salvado, no debe marcarse como ganador ni perdedor.";
            }

            bool ok = _dal.Actualizar(E);

            return ok
                ? "OK: Estadística de pitcheo actualizada exitosamente."
                : "ERROR: No se pudo actualizar la estadística de pitcheo.";
        }
    }
}