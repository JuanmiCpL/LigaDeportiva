using LigaAccesoDatos;
using LogicaDeportiva;
using System;
using System.Windows.Forms;

namespace LigaDeportiva.UI
{
    public partial class form1 : Form
    {
        private readonly EquiposBLL _bll = new EquiposBLL();

        public form1()
        {
            InitializeComponent();
        }

        // ── REGISTRAR ───────────────────────────────────────────────
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Equipos equipo = new Equipos
            {
                Nombre_Equipo = txtNombreEquipo.Text,
                Ciudad = txtCiudad.Text,
                Estadio = txtEstadio.Text,
                Fecha_Fundacion = dtpFechaFundacion.Value,
                Nombre_Manager = txtNombreManager.Text
            };

            string resultado = _bll.Registrar(equipo);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("OK"))
            {
                LimpiarCampos();
                ListarEquipos();
            }
        }

        // ── LISTAR ──────────────────────────────────────────────────
        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarEquipos();
        }

        private void ListarEquipos()
        {
            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = _bll.ObtenerTodos();
        }

        // ── BUSCAR ──────────────────────────────────────────────────
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool tieneId = !string.IsNullOrWhiteSpace(txtId.Text);
            bool tieneNombre = !string.IsNullOrWhiteSpace(txtNombreEquipo.Text);

            if (tieneId && tieneNombre)
            {
                MessageBox.Show("Use solo el campo Id o el campo Nombre, no ambos.");
                return;
            }

            if (!tieneId && !tieneNombre)
            {
                MessageBox.Show("Ingrese un Id o un nombre para buscar.");
                return;
            }

            List<Equipos> resultado;

            if (tieneId)
            {
                if (!int.TryParse(txtId.Text, out int idEquipo))
                {
                    MessageBox.Show("El Id debe ser un número válido.");
                    return;
                }
                resultado = _bll.BuscarPorId(idEquipo);
            }
            else
            {
                resultado = _bll.Buscar(txtNombreEquipo.Text);
            }

            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = resultado;

            if (resultado.Count == 0)
            {
                MessageBox.Show("No se encontraron equipos con ese criterio.");
            }
        }

        // ── ELIMINAR ────────────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int idEquipo))
            {
                MessageBox.Show("Debe ingresar un Id de equipo válido.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar el equipo con Id {idEquipo}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes) return;

            string resultado = _bll.Eliminar(idEquipo);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("OK"))
            {
                LimpiarCampos();
                ListarEquipos();
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombreEquipo.Clear();
            txtCiudad.Clear();
            txtEstadio.Clear();
            txtNombreManager.Clear();
        }

        private void aaaaa(object sender, EventArgs e)
        {

        }
    }
}