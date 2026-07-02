namespace LigaDeportiva.UI
{
    partial class frmPrincipal
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
            label1 = new Label();
            label2 = new Label();
            btnIrEquipos = new Button();
            btnIrJugadores = new Button();
            btnIrJuegos = new Button();
            btnIrEstadisticasOfensivas = new Button();
            btnIrEstadisticasPitcheo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 25);
            label1.Name = "label1";
            label1.Size = new Size(503, 31);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestión de Pelota (Liga Deportiva)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 69);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 1;
            label2.Text = "Seleccione una opcion:";
            // 
            // btnIrEquipos
            // 
            btnIrEquipos.BackColor = SystemColors.ActiveCaption;
            btnIrEquipos.ForeColor = SystemColors.ControlText;
            btnIrEquipos.Location = new Point(254, 114);
            btnIrEquipos.Name = "btnIrEquipos";
            btnIrEquipos.Size = new Size(277, 46);
            btnIrEquipos.TabIndex = 2;
            btnIrEquipos.Text = "EQUIPOS";
            btnIrEquipos.UseVisualStyleBackColor = false;
            btnIrEquipos.Click += btnIrEquipos_Click;
            // 
            // btnIrJugadores
            // 
            btnIrJugadores.BackColor = SystemColors.ActiveCaption;
            btnIrJugadores.Location = new Point(254, 184);
            btnIrJugadores.Name = "btnIrJugadores";
            btnIrJugadores.Size = new Size(277, 46);
            btnIrJugadores.TabIndex = 3;
            btnIrJugadores.Text = "JUGADORES";
            btnIrJugadores.UseVisualStyleBackColor = false;
            btnIrJugadores.Click += btnIrJugadores_Click;
            // 
            // btnIrJuegos
            // 
            btnIrJuegos.BackColor = SystemColors.ActiveCaption;
            btnIrJuegos.Location = new Point(254, 252);
            btnIrJuegos.Name = "btnIrJuegos";
            btnIrJuegos.Size = new Size(277, 46);
            btnIrJuegos.TabIndex = 4;
            btnIrJuegos.Text = "JUEGOS";
            btnIrJuegos.UseVisualStyleBackColor = false;
            // 
            // btnIrEstadisticasOfensivas
            // 
            btnIrEstadisticasOfensivas.BackColor = SystemColors.ActiveCaption;
            btnIrEstadisticasOfensivas.Location = new Point(254, 320);
            btnIrEstadisticasOfensivas.Name = "btnIrEstadisticasOfensivas";
            btnIrEstadisticasOfensivas.Size = new Size(277, 46);
            btnIrEstadisticasOfensivas.TabIndex = 5;
            btnIrEstadisticasOfensivas.Text = "ESTADISTICAS OFENSIVAS";
            btnIrEstadisticasOfensivas.UseVisualStyleBackColor = false;
            btnIrEstadisticasOfensivas.Click += btnIrEstadisticasOfensivas_Click;
            // 
            // btnIrEstadisticasPitcheo
            // 
            btnIrEstadisticasPitcheo.BackColor = SystemColors.ActiveCaption;
            btnIrEstadisticasPitcheo.Location = new Point(254, 392);
            btnIrEstadisticasPitcheo.Name = "btnIrEstadisticasPitcheo";
            btnIrEstadisticasPitcheo.Size = new Size(277, 46);
            btnIrEstadisticasPitcheo.TabIndex = 6;
            btnIrEstadisticasPitcheo.Text = "ESTADISTICAS DE PITCHEO";
            btnIrEstadisticasPitcheo.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(795, 459);
            Controls.Add(btnIrEstadisticasPitcheo);
            Controls.Add(btnIrEstadisticasOfensivas);
            Controls.Add(btnIrJuegos);
            Controls.Add(btnIrJugadores);
            Controls.Add(btnIrEquipos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnIrEquipos;
        private Button btnIrJugadores;
        private Button btnIrJuegos;
        private Button btnIrEstadisticasOfensivas;
        private Button btnIrEstadisticasPitcheo;
    }
}