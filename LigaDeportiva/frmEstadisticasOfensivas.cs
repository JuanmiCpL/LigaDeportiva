using LogicaDeportiva;
using LigaAccesoDatos;
using System;
using System.Windows.Forms;

namespace LigaDeportiva.UI
{
    public partial class frmEstadisticasOfensivas : Form
    {
        private readonly EstadisticasOfensivasBLL _statsBLL = new EstadisticasOfensivasBLL();
        private int _idEstadisticaSeleccionada = 0; // 0 = ningún registro seleccionado (modo "nuevo")

        public frmEstadisticasOfensivas()
        {
            InitializeComponent();

            txtTurnoBate.TextChanged += (s, e) => ActualizarCalculos();
            txtHits.TextChanged += (s, e) => ActualizarCalculos();
            txtBasesPorBola.TextChanged += (s, e) => ActualizarCalculos();
            dgvStats.CellDoubleClick += DgvStats_CellDoubleClick;
        }

        private void ActualizarCalculos()
        {
            if (!int.TryParse(txtTurnoBate.Text, out int ab)) ab = 0;
            if (!int.TryParse(txtHits.Text, out int h)) h = 0;
            if (!int.TryParse(txtBasesPorBola.Text, out int bb)) bb = 0;

            EstadisticasOfensivas stats = new EstadisticasOfensivas
            {
                Turnos_Al_Bate_AB = ab,
                Hits_H = h,
                Bases_Por_Bolas_BB = bb
            };

            double promBate = _statsBLL.Calcular(stats);

            double obp = (ab + bb) > 0 ? Math.Round((double)(h + bb) / (ab + bb), 3) : 0;

            lblProBate.Text = promBate.ToString("0.000");
            lblOBP.Text = obp.ToString("0.000");

            pgbRendimiento.Maximum = 400;
            pgbRendimiento.Value = Math.Min((int)(promBate * 1000), 400);
        }

        private EstadisticasOfensivas LeerStatsDesdeForm()
        {
            if (!int.TryParse(txtIdJugador.Text, out int idJugador) || idJugador <= 0)
            {
                MessageBox.Show("Ingrese un Id de jugador válido.");
                return null;
            }

            if (!int.TryParse(txtIdJuego.Text, out int idJuego) || idJuego <= 0)
            {
                MessageBox.Show("Ingrese un Id de juego válido.");
                return null;
            }

            if (!int.TryParse(txtTurnoBate.Text, out int ab) || ab <= 0)
            {
                MessageBox.Show("Los turnos al bate son obligatorios y deben ser mayor a 0.");
                return null;
            }

            int.TryParse(txtHits.Text, out int h);
            int.TryParse(txtHomerun.Text, out int hr);
            int.TryParse(txtCarrerasE.Text, out int rbi);
            int.TryParse(txtBasesPorBola.Text, out int bb);
            int.TryParse(txtPonches.Text, out int so);
            int.TryParse(txtBasesRobadas.Text, out int sb);
            int.TryParse(txtDobles.Text, out int dobles);
            int.TryParse(txtTriples.Text, out int triples);
            int.TryParse(txtCarrerasA.Text, out int carrerasA);

            return new EstadisticasOfensivas
            {
                Id_Estadisticas_Ofensivas = _idEstadisticaSeleccionada,
                Id_Jugador = idJugador,
                Id_Juego = idJuego,
                Turnos_Al_Bate_AB = ab,
                Hits_H = h,
                Jonrones_HR = hr,
                Carreras_Empujadas_RBI = rbi,
                Bases_Por_Bolas_BB = bb,
                Ponches_SO = so,
                Bases_Robadas_SB = sb,
                Dobles_2B = dobles,
                Triples_3B = triples,
                Carreras_Anotadas_R = carrerasA
            };
        }

        private void btnGuardarStats_Click(object sender, EventArgs e)
        {
            EstadisticasOfensivas stats = LeerStatsDesdeForm();
            if (stats == null) return;

            string resultado = _statsBLL.Registrar(stats);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("OK"))
            {
                LimpiarCampos();
                CargarStats();
            }
        }

        private void btnActualizarStats_Click(object sender, EventArgs e)
        {
            if (_idEstadisticaSeleccionada <= 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic) para actualizar.");
                return;
            }

            EstadisticasOfensivas stats = LeerStatsDesdeForm();
            if (stats == null) return;

            string resultado = _statsBLL.Actualizar(stats);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("OK"))
            {
                LimpiarCampos();
                CargarStats();
            }
        }

        private void btnEliminarStats_Click(object sender, EventArgs e)
        {
            if (_idEstadisticaSeleccionada <= 0)
            {
                MessageBox.Show("Seleccione un registro de la lista (doble clic) para eliminar.");
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Seguro que desea eliminar esta estadística?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo);

            if (confirmacion != DialogResult.Yes) return;

            string resultado = _statsBLL.Eliminar(_idEstadisticaSeleccionada);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("OK"))
            {
                LimpiarCampos();
                CargarStats();
            }
        }

        private void btnListarStats_Click(object sender, EventArgs e)
        {
            CargarStats();
        }

        private void CargarStats()
        {
            dgvStats.DataSource = _statsBLL.ObtenerTodos();

            if (dgvStats.Columns["Jugadores"] != null)
                dgvStats.Columns["Jugadores"].Visible = false;

            if (dgvStats.Columns["Juegos"] != null)
                dgvStats.Columns["Juegos"].Visible = false;
        }

        private void DgvStats_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvStats.Rows[e.RowIndex].DataBoundItem as EstadisticasOfensivas;
            if (fila == null) return;

            _idEstadisticaSeleccionada = fila.Id_Estadisticas_Ofensivas;

            txtIdJugador.Text = fila.Id_Jugador.ToString();
            txtIdJuego.Text = fila.Id_Juego.ToString();
            txtTurnoBate.Text = fila.Turnos_Al_Bate_AB.ToString();
            txtHits.Text = fila.Hits_H.ToString();
            txtHomerun.Text = fila.Jonrones_HR.ToString();
            txtCarrerasE.Text = fila.Carreras_Empujadas_RBI.ToString();
            txtBasesPorBola.Text = fila.Bases_Por_Bolas_BB.ToString();
            txtPonches.Text = fila.Ponches_SO.ToString();
            txtBasesRobadas.Text = fila.Bases_Robadas_SB.ToString();
            txtDobles.Text = fila.Dobles_2B.ToString();
            txtTriples.Text = fila.Triples_3B.ToString();
            txtCarrerasA.Text = fila.Triples_3B.ToString();
        }

        private void LimpiarCampos()
        {
            txtTurnoBate.Clear();
            txtHits.Clear();
            txtHomerun.Clear();
            txtCarrerasE.Clear();
            txtBasesPorBola.Clear();
            txtPonches.Clear();
            txtBasesRobadas.Clear();
            txtDobles.Clear();
            txtTriples.Clear();
            txtCarrerasA.Clear();
            txtIdJuego.Clear();
            txtIdJugador.Clear();
            lblProBate.Text = "0.000";
            lblOBP.Text = "0.000";
            pgbRendimiento.Value = 0;
            _idEstadisticaSeleccionada = 0;
        }
    }
}