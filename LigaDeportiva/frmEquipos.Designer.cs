namespace LigaDeportiva.UI
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreEquipo = new TextBox();
            txtCiudad = new TextBox();
            txtEstadio = new TextBox();
            txtNombreManager = new TextBox();
            label6 = new Label();
            dtpFechaFundacion = new DateTimePicker();
            btnRegistrar = new Button();
            btnListar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            dgvEquipos = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 83);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Del Equipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 124);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 170);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Estadio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 216);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha De Fundacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 259);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 4;
            label5.Text = "Nombe Del Manager:";
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(209, 80);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(513, 27);
            txtNombreEquipo.TabIndex = 5;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(209, 121);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(513, 27);
            txtCiudad.TabIndex = 6;
            // 
            // txtEstadio
            // 
            txtEstadio.Location = new Point(209, 167);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(513, 27);
            txtEstadio.TabIndex = 7;
            // 
            // txtNombreManager
            // 
            txtNombreManager.Location = new Point(209, 256);
            txtNombreManager.Name = "txtNombreManager";
            txtNombreManager.Size = new Size(513, 27);
            txtNombreManager.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(32, 9);
            label6.Name = "label6";
            label6.Size = new Size(256, 20);
            label6.TabIndex = 9;
            label6.Text = "FORMULARIO DE EQUIPOS:";
            // 
            // dtpFechaFundacion
            // 
            dtpFechaFundacion.Location = new Point(209, 211);
            dtpFechaFundacion.Name = "dtpFechaFundacion";
            dtpFechaFundacion.Size = new Size(513, 27);
            dtpFechaFundacion.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Location = new Point(35, 297);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(168, 51);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registar Nuevo Equipo";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.FromArgb(224, 224, 224);
            btnListar.Cursor = Cursors.Hand;
            btnListar.Location = new Point(557, 297);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(165, 51);
            btnListar.TabIndex = 12;
            btnListar.Text = "Listar Todos los Equipos";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(386, 297);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(165, 51);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar Equipo";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(192, 255, 255);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(209, 297);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(165, 51);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar Nuevo Equipo";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(32, 399);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.Size = new Size(686, 161);
            dgvEquipos.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 373);
            label7.Name = "label7";
            label7.Size = new Size(145, 23);
            label7.TabIndex = 16;
            label7.Text = "Lista de Equipos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(35, 42);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 17;
            label8.Text = "Id Del Equipo:";
            // 
            // txtId
            // 
            txtId.Location = new Point(209, 39);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "\"Solo utilizarlo para buscar un equipo ya registrado.\"";
            txtId.Size = new Size(513, 27);
            txtId.TabIndex = 18;
            txtId.TextChanged += aaaaa;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(763, 582);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvEquipos);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnListar);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFechaFundacion);
            Controls.Add(label6);
            Controls.Add(txtNombreManager);
            Controls.Add(txtEstadio);
            Controls.Add(txtCiudad);
            Controls.Add(txtNombreEquipo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "form1";
            Text = "Registro de Equipos de Pelota";
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreEquipo;
        private TextBox txtCiudad;
        private TextBox txtEstadio;
        private TextBox txtNombreManager;
        private Label label6;
        private DateTimePicker dtpFechaFundacion;
        private Button btnRegistrar;
        private Button btnListar;
        private Button btnEliminar;
        private Button btnBuscar;
        private DataGridView dgvEquipos;
        private Label label7;
        private Label label8;
        private TextBox txtId;
    }
}
