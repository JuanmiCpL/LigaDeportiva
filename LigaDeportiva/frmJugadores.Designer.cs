namespace LigaDeportiva.UI
{
    partial class frmJugadores
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
            groupBox1 = new GroupBox();
            nunCamiseta = new NumericUpDown();
            txtApellido = new TextBox();
            chkImportado = new CheckBox();
            chkActivo = new CheckBox();
            txtPeso = new TextBox();
            label12 = new Label();
            txtTemporada = new TextBox();
            txtAltura = new TextBox();
            rbDiestro = new RadioButton();
            txtPosicion = new TextBox();
            rbZurdo = new RadioButton();
            rbLosDosh = new RadioButton();
            txtNacionalidad = new TextBox();
            txtEdad = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            label11 = new Label();
            nada = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnListar = new Button();
            btnLimpiar = new Button();
            dgvJugadores = new DataGridView();
            txtIdEquipo = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nunCamiseta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(txtIdEquipo);
            groupBox1.Controls.Add(nunCamiseta);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(chkImportado);
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Controls.Add(txtPeso);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtTemporada);
            groupBox1.Controls.Add(txtAltura);
            groupBox1.Controls.Add(rbDiestro);
            groupBox1.Controls.Add(txtPosicion);
            groupBox1.Controls.Add(rbZurdo);
            groupBox1.Controls.Add(rbLosDosh);
            groupBox1.Controls.Add(txtNacionalidad);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(nada);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 382);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Del Jugador";
            // 
            // nunCamiseta
            // 
            nunCamiseta.Location = new Point(501, 59);
            nunCamiseta.Name = "nunCamiseta";
            nunCamiseta.Size = new Size(125, 27);
            nunCamiseta.TabIndex = 30;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(251, 58);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(239, 27);
            txtApellido.TabIndex = 28;
            // 
            // chkImportado
            // 
            chkImportado.AutoSize = true;
            chkImportado.Cursor = Cursors.Hand;
            chkImportado.Location = new Point(524, 331);
            chkImportado.Name = "chkImportado";
            chkImportado.Size = new Size(102, 24);
            chkImportado.TabIndex = 27;
            chkImportado.Text = "Importado";
            chkImportado.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Cursor = Cursors.Hand;
            chkActivo.Location = new Point(265, 334);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(173, 24);
            chkActivo.TabIndex = 26;
            chkActivo.Text = "Activo en Temporada";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(6, 331);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(239, 27);
            txtPeso.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 300);
            label12.Name = "label12";
            label12.Size = new Size(74, 20);
            label12.TabIndex = 24;
            label12.Text = "Peso (Kg):";
            // 
            // txtTemporada
            // 
            txtTemporada.Location = new Point(6, 259);
            txtTemporada.Name = "txtTemporada";
            txtTemporada.Size = new Size(239, 27);
            txtTemporada.TabIndex = 23;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(501, 191);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 22;
            // 
            // rbDiestro
            // 
            rbDiestro.AutoSize = true;
            rbDiestro.Location = new Point(265, 285);
            rbDiestro.Name = "rbDiestro";
            rbDiestro.Size = new Size(78, 24);
            rbDiestro.TabIndex = 21;
            rbDiestro.TabStop = true;
            rbDiestro.Text = "Diestro";
            rbDiestro.UseVisualStyleBackColor = true;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(251, 191);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(239, 27);
            txtPosicion.TabIndex = 17;
            // 
            // rbZurdo
            // 
            rbZurdo.AutoSize = true;
            rbZurdo.Location = new Point(391, 285);
            rbZurdo.Name = "rbZurdo";
            rbZurdo.Size = new Size(70, 24);
            rbZurdo.TabIndex = 20;
            rbZurdo.TabStop = true;
            rbZurdo.Text = "Zurdo";
            rbZurdo.UseVisualStyleBackColor = true;
            // 
            // rbLosDosh
            // 
            rbLosDosh.AutoSize = true;
            rbLosDosh.Location = new Point(494, 285);
            rbLosDosh.Name = "rbLosDosh";
            rbLosDosh.Size = new Size(132, 24);
            rbLosDosh.TabIndex = 19;
            rbLosDosh.TabStop = true;
            rbLosDosh.Text = "Diestro / Zurdo";
            rbLosDosh.UseVisualStyleBackColor = true;
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(6, 191);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(239, 27);
            txtNacionalidad.TabIndex = 18;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(501, 123);
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 16;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(251, 123);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(239, 27);
            dtpFechaNacimiento.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(501, 168);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 11;
            label11.Text = "Altura(m):";
            // 
            // nada
            // 
            nada.AutoSize = true;
            nada.Location = new Point(6, 236);
            nada.Name = "nada";
            nada.Size = new Size(88, 20);
            nada.TabIndex = 10;
            nada.Text = "Temporada:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(367, 236);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 9;
            label9.Text = "Bateo / Lanzador";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(251, 168);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 8;
            label8.Text = "Posición:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 168);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 7;
            label7.Text = "Nacionalidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 97);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 6;
            label6.Text = "ID Equipo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 97);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 97);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 35);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 3;
            label3.Text = "No. Camiseta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 35);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(239, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Location = new Point(12, 635);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(127, 40);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 255, 128);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(145, 635);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(127, 40);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(412, 635);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 40);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.Gray;
            btnListar.Cursor = Cursors.Hand;
            btnListar.Location = new Point(545, 635);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(127, 40);
            btnListar.TabIndex = 5;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(277, 635);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(12, 400);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(660, 208);
            dgvJugadores.TabIndex = 7;
            // 
            // txtIdEquipo
            // 
            txtIdEquipo.Location = new Point(6, 125);
            txtIdEquipo.Name = "txtIdEquipo";
            txtIdEquipo.PlaceholderText = "\"Solo para eliminar un equipo\"";
            txtIdEquipo.Size = new Size(239, 27);
            txtIdEquipo.TabIndex = 31;
            // 
            // frmJugadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(695, 702);
            Controls.Add(dgvJugadores);
            Controls.Add(btnLimpiar);
            Controls.Add(btnListar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnRegistrar);
            Controls.Add(groupBox1);
            Name = "frmJugadores";
            Text = "frmJugadores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nunCamiseta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label11;
        private Label nada;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNombre;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox5;
        private RadioButton rbDiestro;
        private TextBox txtPosicion;
        private RadioButton rbZurdo;
        private RadioButton rbLosDosh;
        private TextBox txtNacionalidad;
        private TextBox txtEdad;
        private TextBox txtAltura;
        private TextBox txtTemporada;
        private TextBox txtPeso;
        private Label label12;
        private CheckBox chkImportado;
        private CheckBox chkActivo;
        private TextBox txtApellido;
        private NumericUpDown nunCamiseta;
        private Button btnRegistrar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnListar;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnLimpiar;
        private DataGridView dgvJugadores;
        private TextBox txtIdEquipo;
    }
}