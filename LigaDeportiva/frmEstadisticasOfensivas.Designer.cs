namespace LigaDeportiva.UI
{
    partial class frmEstadisticasOfensivas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardarStats = new Button();
            label10 = new Label();
            txtIdJuego = new TextBox();
            label = new Label();
            label21 = new Label();
            labell = new Label();
            pgbRendimiento = new ProgressBar();
            lblOBP = new Label();
            txtBasesPorBola = new TextBox();
            txtDobles = new TextBox();
            txtPonches = new TextBox();
            txtBasesRobadas = new TextBox();
            txtCarrerasE = new TextBox();
            txtHits = new TextBox();
            txtHomerun = new TextBox();
            txtTurnoBate = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            btnActualizarStats = new Button();
            dgvStats = new DataGridView();
            txtIdJugador = new TextBox();
            label1 = new Label();
            btnEliminarStats = new Button();
            btnListarStats = new Button();
            lblProBate = new Label();
            txtTriples = new TextBox();
            label2 = new Label();
            txtCarrerasA = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarStats
            // 
            btnGuardarStats.BackColor = Color.FromArgb(128, 255, 128);
            btnGuardarStats.Location = new Point(26, 345);
            btnGuardarStats.Name = "btnGuardarStats";
            btnGuardarStats.Size = new Size(373, 29);
            btnGuardarStats.TabIndex = 123;
            btnGuardarStats.Text = "Guardar Stats";
            btnGuardarStats.UseVisualStyleBackColor = false;
            btnGuardarStats.Click += btnGuardarStats_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(222, 51);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 122;
            label10.Text = "ID Juego:";
            // 
            // txtIdJuego
            // 
            txtIdJuego.Location = new Point(222, 74);
            txtIdJuego.Name = "txtIdJuego";
            txtIdJuego.Size = new Size(177, 27);
            txtIdJuego.TabIndex = 121;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(283, 248);
            label.Name = "label";
            label.Size = new Size(37, 20);
            label.TabIndex = 120;
            label.Text = "OBP";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(538, 248);
            label21.Name = "label21";
            label21.Size = new Size(137, 20);
            label21.TabIndex = 119;
            label21.Text = "Rendimiento Visual";
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labell.Location = new Point(26, 248);
            labell.Name = "labell";
            labell.Size = new Size(126, 20);
            labell.TabIndex = 118;
            labell.Text = "Promedio Al Bate";
            // 
            // pgbRendimiento
            // 
            pgbRendimiento.Location = new Point(418, 277);
            pgbRendimiento.Name = "pgbRendimiento";
            pgbRendimiento.Size = new Size(370, 29);
            pgbRendimiento.TabIndex = 117;
            // 
            // lblOBP
            // 
            lblOBP.AutoSize = true;
            lblOBP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOBP.Location = new Point(298, 278);
            lblOBP.Name = "lblOBP";
            lblOBP.Size = new Size(0, 28);
            lblOBP.TabIndex = 116;
            // 
            // txtBasesPorBola
            // 
            txtBasesPorBola.Location = new Point(222, 203);
            txtBasesPorBola.Name = "txtBasesPorBola";
            txtBasesPorBola.Size = new Size(177, 27);
            txtBasesPorBola.TabIndex = 115;
            // 
            // txtDobles
            // 
            txtDobles.Location = new Point(222, 136);
            txtDobles.Name = "txtDobles";
            txtDobles.Size = new Size(177, 27);
            txtDobles.TabIndex = 114;
            // 
            // txtPonches
            // 
            txtPonches.Location = new Point(418, 203);
            txtPonches.Name = "txtPonches";
            txtPonches.Size = new Size(177, 27);
            txtPonches.TabIndex = 113;
            // 
            // txtBasesRobadas
            // 
            txtBasesRobadas.Location = new Point(611, 203);
            txtBasesRobadas.Name = "txtBasesRobadas";
            txtBasesRobadas.Size = new Size(177, 27);
            txtBasesRobadas.TabIndex = 112;
            // 
            // txtCarrerasE
            // 
            txtCarrerasE.Location = new Point(26, 203);
            txtCarrerasE.Name = "txtCarrerasE";
            txtCarrerasE.Size = new Size(177, 27);
            txtCarrerasE.TabIndex = 111;
            // 
            // txtHits
            // 
            txtHits.Location = new Point(26, 136);
            txtHits.Name = "txtHits";
            txtHits.Size = new Size(177, 27);
            txtHits.TabIndex = 110;
            // 
            // txtHomerun
            // 
            txtHomerun.Location = new Point(611, 136);
            txtHomerun.Name = "txtHomerun";
            txtHomerun.Size = new Size(177, 27);
            txtHomerun.TabIndex = 109;
            // 
            // txtTurnoBate
            // 
            txtTurnoBate.Location = new Point(418, 74);
            txtTurnoBate.Name = "txtTurnoBate";
            txtTurnoBate.Size = new Size(177, 27);
            txtTurnoBate.TabIndex = 108;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(418, 180);
            label20.Name = "label20";
            label20.Size = new Size(98, 20);
            label20.TabIndex = 107;
            label20.Text = "Ponches (SO):";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(611, 180);
            label19.Name = "label19";
            label19.Size = new Size(142, 20);
            label19.TabIndex = 106;
            label19.Text = "Bases Robadas (SB):";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(222, 113);
            label18.Name = "label18";
            label18.Size = new Size(90, 20);
            label18.TabIndex = 105;
            label18.Text = "Dobles (2B):";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(222, 180);
            label17.Name = "label17";
            label17.Size = new Size(146, 20);
            label17.TabIndex = 104;
            label17.Text = "Bases Por Bolas (BB):";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(26, 180);
            label16.Name = "label16";
            label16.Size = new Size(117, 20);
            label16.TabIndex = 103;
            label16.Text = "Carreras E. (RBI):";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(611, 113);
            label15.Name = "label15";
            label15.Size = new Size(116, 20);
            label15.TabIndex = 102;
            label15.Text = "Home Run (HR):";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(26, 113);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 101;
            label14.Text = "Hits (H):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(418, 51);
            label13.Name = "label13";
            label13.Size = new Size(139, 20);
            label13.TabIndex = 100;
            label13.Text = "Turnos al Bate (AB):";
            // 
            // btnActualizarStats
            // 
            btnActualizarStats.Location = new Point(418, 345);
            btnActualizarStats.Name = "btnActualizarStats";
            btnActualizarStats.Size = new Size(370, 29);
            btnActualizarStats.TabIndex = 124;
            btnActualizarStats.Text = "Actualizar Stats";
            btnActualizarStats.UseVisualStyleBackColor = true;
            btnActualizarStats.Click += btnActualizarStats_Click;
            // 
            // dgvStats
            // 
            dgvStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStats.Location = new Point(26, 425);
            dgvStats.Name = "dgvStats";
            dgvStats.RowHeadersWidth = 51;
            dgvStats.Size = new Size(762, 188);
            dgvStats.TabIndex = 125;
            // 
            // txtIdJugador
            // 
            txtIdJugador.Location = new Point(26, 74);
            txtIdJugador.Name = "txtIdJugador";
            txtIdJugador.Size = new Size(177, 27);
            txtIdJugador.TabIndex = 126;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 51);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 127;
            label1.Text = "ID Jugador:";
            // 
            // btnEliminarStats
            // 
            btnEliminarStats.Location = new Point(26, 380);
            btnEliminarStats.Name = "btnEliminarStats";
            btnEliminarStats.Size = new Size(373, 29);
            btnEliminarStats.TabIndex = 128;
            btnEliminarStats.Text = "Eliminar Stats";
            btnEliminarStats.UseVisualStyleBackColor = true;
            btnEliminarStats.Click += btnEliminarStats_Click;
            // 
            // btnListarStats
            // 
            btnListarStats.Location = new Point(418, 380);
            btnListarStats.Name = "btnListarStats";
            btnListarStats.Size = new Size(370, 29);
            btnListarStats.TabIndex = 129;
            btnListarStats.Text = "Listar Stats";
            btnListarStats.UseVisualStyleBackColor = true;
            btnListarStats.Click += btnListarStats_Click;
            // 
            // lblProBate
            // 
            lblProBate.AutoSize = true;
            lblProBate.Location = new Point(61, 287);
            lblProBate.Name = "lblProBate";
            lblProBate.Size = new Size(50, 20);
            lblProBate.TabIndex = 130;
            lblProBate.Text = "label2";
            // 
            // txtTriples
            // 
            txtTriples.Location = new Point(418, 136);
            txtTriples.Name = "txtTriples";
            txtTriples.Size = new Size(177, 27);
            txtTriples.TabIndex = 131;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 113);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 132;
            label2.Text = "Triples (3B):";
            // 
            // txtCarrerasA
            // 
            txtCarrerasA.Location = new Point(611, 74);
            txtCarrerasA.Name = "txtCarrerasA";
            txtCarrerasA.Size = new Size(177, 27);
            txtCarrerasA.TabIndex = 133;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(611, 51);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 134;
            label3.Text = "Carreras Anotadas (R):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(274, 9);
            label4.Name = "label4";
            label4.Size = new Size(248, 33);
            label4.TabIndex = 135;
            label4.Text = "Estadisticas Ofensivas";
            // 
            // frmEstadisticasOfensivas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 638);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCarrerasA);
            Controls.Add(label2);
            Controls.Add(txtTriples);
            Controls.Add(lblProBate);
            Controls.Add(btnListarStats);
            Controls.Add(btnEliminarStats);
            Controls.Add(label1);
            Controls.Add(txtIdJugador);
            Controls.Add(dgvStats);
            Controls.Add(btnActualizarStats);
            Controls.Add(btnGuardarStats);
            Controls.Add(label10);
            Controls.Add(txtIdJuego);
            Controls.Add(label);
            Controls.Add(label21);
            Controls.Add(labell);
            Controls.Add(pgbRendimiento);
            Controls.Add(lblOBP);
            Controls.Add(txtBasesPorBola);
            Controls.Add(txtDobles);
            Controls.Add(txtPonches);
            Controls.Add(txtBasesRobadas);
            Controls.Add(txtCarrerasE);
            Controls.Add(txtHits);
            Controls.Add(txtHomerun);
            Controls.Add(txtTurnoBate);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Name = "frmEstadisticasOfensivas";
            Text = "frmEstadisticasOfensivas";
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarStats;
        private Label label10;
        private TextBox txtIdJuego;
        private Label label;
        private Label label21;
        private Label labell;
        private ProgressBar pgbRendimiento;
        private Label lblOBP;
        private TextBox txtBasesPorBola;
        private TextBox txtDobles;
        private TextBox txtPonches;
        private TextBox txtBasesRobadas;
        private TextBox txtCarrerasE;
        private TextBox txtHits;
        private TextBox txtHomerun;
        private TextBox txtTurnoBate;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button btnActualizarStats;
        private DataGridView dgvStats;
        private TextBox txtIdJugador;
        private Label label1;
        private Button btnEliminarStats;
        private Button btnListarStats;
        private Label lblProBate;
        private TextBox txtTriples;
        private Label label2;
        private TextBox txtCarrerasA;
        private Label label3;
        private Label label4;
    }
}