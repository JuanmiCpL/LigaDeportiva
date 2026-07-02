using LigaAccesoDatos;
using LogicaDeportiva;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LigaDeportiva.UI
{
    public partial class frmJugadores : Form
    {
        private readonly JugadoresBLL _bll = new JugadoresBLL();
        private readonly EstadisticasOfensivasBLL _statsBLL = new EstadisticasOfensivasBLL();

        public frmJugadores()
        {
            InitializeComponent();

            // Calcular edad automáticamente al cambiar fecha
            dtpFechaNacimiento.ValueChanged += (s, e) => CalcularEdad();

            // Calcular estadísticas automáticamente al escribir
        }

        // ── CALCULAR EDAD ────────────────────────────────────────────
        private void CalcularEdad()
        {
            DateTime hoy = DateTime.Today;
            DateTime nacimiento = dtpFechaNacimiento.Value;
            int edad = hoy.Year - nacimiento.Year;
            if (hoy < nacimiento.AddYears(edad)) edad--;
            txtEdad.Text = edad.ToString();
        }

        // ── REGISTRAR ───────────────────────────────────────────────
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string batea = rbDiestro.Checked ? "D" : rbZurdo.Checked ? "Z" : "D/Z";
            string lanza = rbDiestro.Checked ? "D" : rbZurdo.Checked ? "Z" : "D/Z";

            if (!int.TryParse(txtIdEquipo.Text, out int idEquipo) || idEquipo <= 0)
            {
                MessageBox.Show("Ingrese un Id de equipo válido.");
                return;
            }

            Jugadores jugador = new Jugadores
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Numero_Camiseta = (int)nunCamiseta.Value,
                Fecha_Nacimiento = dtpFechaNacimiento.Value,
                Posicion = txtPosicion.Text,
                Batea = batea,
                Lanza = lanza,
                Id_Equipo = idEquipo,
                Nacionalidad = txtNacionalidad.Text,
                Altura = decimal.TryParse(txtAltura.Text, out decimal altura) ? altura : 0,
                Peso = decimal.TryParse(txtPeso.Text, out decimal peso) ? peso : 0,
                Temporadas = int.TryParse(txtTemporada.Text, out int temp) ? temp : 0,
                Activo = chkActivo.Checked,
                Importado = chkImportado.Checked
            };

            string resultado = _bll.Registrar(jugador);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("OK"))
            {
                LimpiarCampos();
                ListarJugadores();
            }
        }

        // ── BUSCAR ──────────────────────────────────────────────────
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            var lista = _bll.ObtenerTodos();
            var resultado = lista.FindAll(j =>
                j.Nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0 ||
                j.Apellido.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
            );

            dgvJugadores.DataSource = null;
            dgvJugadores.DataSource = resultado;

            if (dgvJugadores.Columns["Equipos"] != null)
                dgvJugadores.Columns["Equipos"].Visible = false;

            if (resultado.Count == 0)
                MessageBox.Show("No se encontraron jugadores.");
        }

        // ── LISTAR ──────────────────────────────────────────────────
        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarJugadores();
        }

        private void ListarJugadores()
        {
            dgvJugadores.DataSource = null;
            dgvJugadores.DataSource = _bll.ObtenerTodos();

            if (dgvJugadores.Columns["Equipos"] != null)
                dgvJugadores.Columns["Equipos"].Visible = false;
        }

        // ── ELIMINAR ────────────────────────────────────────────────
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdEquipo.Text, out int idJugador) || idJugador <= 0)
            {
                MessageBox.Show("Ingrese un Id de jugador válido.");
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar el jugador con Id {idJugador}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes) return;

            string resultado = _bll.Eliminar(idJugador);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("OK"))
            {
                LimpiarCampos();
                ListarJugadores();
            }
        }

        // ── LIMPIAR ──────────────────────────────────────────────────
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            nunCamiseta.Value = 0;
            txtIdEquipo.Clear();
            txtEdad.Clear();
            txtNacionalidad.Clear();
            txtPosicion.Clear();
            txtAltura.Clear();
            txtTemporada.Clear();
            txtPeso.Clear();
            rbDiestro.Checked = false;
            rbZurdo.Checked = false;
            rbLosDosh.Checked = false;
            chkActivo.Checked = false;
            chkImportado.Checked = false;
        }
    }
}