namespace Dashboard_ClinicaSePrice.pesañas
{
    partial class GestionTurnos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionTurnos));
            dgtvTurnos = new DataGridView();
            dtpTurno = new DateTimePicker();
            picActividad = new PictureBox();
            picCantCuotasPA = new PictureBox();
            cmbEspecialidad = new ComboBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            cmbMedico = new ComboBox();
            pictureBox8 = new PictureBox();
            label3 = new Label();
            txtDniGestion = new TextBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            btnBuscarPaciente = new CustomBotonDos();
            btnRegistrarTurno = new CustomBotonDos();
            lblTurnosDisp = new Label();
            cmbConsulta = new ComboBox();
            pictureBox1 = new PictureBox();
            btnBuscarTurno = new CustomBotonDos();
            dateTimePicker1 = new DateTimePicker();
            lblFechaDesde = new Label();
            lblFechaHasta = new Label();
            lblPractica = new Label();
            ((System.ComponentModel.ISupportInitialize)dgtvTurnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCantCuotasPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgtvTurnos
            // 
            dgtvTurnos.AllowUserToAddRows = false;
            dgtvTurnos.AllowUserToDeleteRows = false;
            dgtvTurnos.BackgroundColor = Color.White;
            dgtvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvTurnos.Location = new Point(17, 210);
            dgtvTurnos.Margin = new Padding(3, 2, 3, 2);
            dgtvTurnos.Name = "dgtvTurnos";
            dgtvTurnos.ReadOnly = true;
            dgtvTurnos.RowHeadersWidth = 51;
            dgtvTurnos.RowTemplate.Height = 29;
            dgtvTurnos.Size = new Size(761, 221);
            dgtvTurnos.TabIndex = 23;
            // 
            // dtpTurno
            // 
            dtpTurno.CalendarForeColor = Color.Black;
            dtpTurno.CalendarTitleForeColor = Color.FromArgb(74, 102, 174);
            dtpTurno.Cursor = Cursors.Hand;
            dtpTurno.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTurno.Format = DateTimePickerFormat.Short;
            dtpTurno.Location = new Point(514, 147);
            dtpTurno.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpTurno.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTurno.Name = "dtpTurno";
            dtpTurno.Size = new Size(94, 26);
            dtpTurno.TabIndex = 38;
            // 
            // picActividad
            // 
            picActividad.BackgroundImage = (Image)resources.GetObject("picActividad.BackgroundImage");
            picActividad.BackgroundImageLayout = ImageLayout.Stretch;
            picActividad.Location = new Point(497, 139);
            picActividad.Name = "picActividad";
            picActividad.Size = new Size(126, 43);
            picActividad.TabIndex = 37;
            picActividad.TabStop = false;
            // 
            // picCantCuotasPA
            // 
            picCantCuotasPA.BackgroundImage = (Image)resources.GetObject("picCantCuotasPA.BackgroundImage");
            picCantCuotasPA.BackgroundImageLayout = ImageLayout.Stretch;
            picCantCuotasPA.Location = new Point(642, 139);
            picCantCuotasPA.Name = "picCantCuotasPA";
            picCantCuotasPA.Size = new Size(126, 43);
            picCantCuotasPA.TabIndex = 35;
            picCantCuotasPA.TabStop = false;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.Cursor = Cursors.Hand;
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.Enabled = false;
            cmbEspecialidad.FlatStyle = FlatStyle.Popup;
            cmbEspecialidad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEspecialidad.ForeColor = Color.FromArgb(74, 102, 174);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(329, 76);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(189, 28);
            cmbEspecialidad.TabIndex = 40;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(315, 68);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(219, 43);
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(326, 48);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 41;
            label2.Text = "Especialidad";
            // 
            // cmbMedico
            // 
            cmbMedico.Cursor = Cursors.Hand;
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.Enabled = false;
            cmbMedico.FlatStyle = FlatStyle.Popup;
            cmbMedico.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMedico.ForeColor = Color.FromArgb(74, 102, 174);
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(563, 76);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(189, 28);
            cmbMedico.TabIndex = 43;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(549, 68);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(219, 43);
            pictureBox8.TabIndex = 42;
            pictureBox8.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(558, 48);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 44;
            label3.Text = "Médico";
            // 
            // txtDniGestion
            // 
            txtDniGestion.BackColor = Color.FromArgb(73, 162, 203);
            txtDniGestion.BorderStyle = BorderStyle.None;
            txtDniGestion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniGestion.ForeColor = Color.White;
            txtDniGestion.Location = new Point(35, 79);
            txtDniGestion.Margin = new Padding(3, 2, 3, 2);
            txtDniGestion.Multiline = true;
            txtDniGestion.Name = "txtDniGestion";
            txtDniGestion.Size = new Size(214, 22);
            txtDniGestion.TabIndex = 46;
            txtDniGestion.Text = "DNI";
            txtDniGestion.Enter += txtDniGestion_Enter;
            txtDniGestion.KeyPress += txtDniGestion_KeyPress;
            txtDniGestion.Leave += txtDniGestion_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 68);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(255, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(73, 162, 203);
            label1.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 47;
            label1.Text = "Gestión Turnos";
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = Color.FromArgb(29, 65, 81);
            btnBuscarPaciente.Cursor = Cursors.Hand;
            btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPaciente.ForeColor = Color.White;
            btnBuscarPaciente.Location = new Point(17, 119);
            btnBuscarPaciente.Margin = new Padding(3, 2, 3, 2);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(255, 39);
            btnBuscarPaciente.TabIndex = 48;
            btnBuscarPaciente.Text = "BUSCAR PACIENTE";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // btnRegistrarTurno
            // 
            btnRegistrarTurno.BackColor = Color.FromArgb(29, 65, 81);
            btnRegistrarTurno.Cursor = Cursors.Hand;
            btnRegistrarTurno.FlatAppearance.BorderSize = 0;
            btnRegistrarTurno.FlatStyle = FlatStyle.Flat;
            btnRegistrarTurno.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarTurno.ForeColor = Color.White;
            btnRegistrarTurno.Location = new Point(361, 440);
            btnRegistrarTurno.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarTurno.Name = "btnRegistrarTurno";
            btnRegistrarTurno.Size = new Size(192, 39);
            btnRegistrarTurno.TabIndex = 49;
            btnRegistrarTurno.Text = "REGISTRAR TURNO";
            btnRegistrarTurno.UseVisualStyleBackColor = false;
            btnRegistrarTurno.Click += btnRegistrarTurno_Click;
            // 
            // lblTurnosDisp
            // 
            lblTurnosDisp.AutoSize = true;
            lblTurnosDisp.BackColor = Color.FromArgb(73, 162, 203);
            lblTurnosDisp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnosDisp.ForeColor = Color.White;
            lblTurnosDisp.Location = new Point(17, 182);
            lblTurnosDisp.Name = "lblTurnosDisp";
            lblTurnosDisp.Size = new Size(162, 20);
            lblTurnosDisp.TabIndex = 50;
            lblTurnosDisp.Text = "Turnos Disponibles";
            // 
            // cmbConsulta
            // 
            cmbConsulta.Cursor = Cursors.Hand;
            cmbConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConsulta.Enabled = false;
            cmbConsulta.FlatStyle = FlatStyle.Popup;
            cmbConsulta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbConsulta.ForeColor = Color.FromArgb(74, 102, 174);
            cmbConsulta.FormattingEnabled = true;
            cmbConsulta.Location = new Point(329, 147);
            cmbConsulta.Name = "cmbConsulta";
            cmbConsulta.Size = new Size(133, 28);
            cmbConsulta.TabIndex = 52;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(315, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 43);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // btnBuscarTurno
            // 
            btnBuscarTurno.BackColor = Color.FromArgb(29, 65, 81);
            btnBuscarTurno.Cursor = Cursors.Hand;
            btnBuscarTurno.FlatAppearance.BorderSize = 0;
            btnBuscarTurno.FlatStyle = FlatStyle.Flat;
            btnBuscarTurno.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarTurno.ForeColor = Color.White;
            btnBuscarTurno.Location = new Point(576, 440);
            btnBuscarTurno.Margin = new Padding(3, 2, 3, 2);
            btnBuscarTurno.Name = "btnBuscarTurno";
            btnBuscarTurno.Size = new Size(202, 39);
            btnBuscarTurno.TabIndex = 53;
            btnBuscarTurno.Text = "BUSCAR TURNO";
            btnBuscarTurno.UseVisualStyleBackColor = false;
            btnBuscarTurno.Click += btnBuscarTurno_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Black;
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(74, 102, 174);
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(658, 147);
            dateTimePicker1.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(94, 26);
            dateTimePicker1.TabIndex = 54;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaDesde.ForeColor = Color.White;
            lblFechaDesde.Location = new Point(497, 119);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(102, 20);
            lblFechaDesde.TabIndex = 55;
            lblFechaDesde.Text = "Fecha desde";
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaHasta.ForeColor = Color.White;
            lblFechaHasta.Location = new Point(642, 119);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(98, 20);
            lblFechaHasta.TabIndex = 56;
            lblFechaHasta.Text = "Fecha hasta";
            // 
            // lblPractica
            // 
            lblPractica.AutoSize = true;
            lblPractica.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPractica.ForeColor = Color.White;
            lblPractica.Location = new Point(321, 119);
            lblPractica.Name = "lblPractica";
            lblPractica.Size = new Size(66, 20);
            lblPractica.TabIndex = 57;
            lblPractica.Text = "Práctica";
            // 
            // GestionTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            Controls.Add(lblPractica);
            Controls.Add(lblFechaHasta);
            Controls.Add(lblFechaDesde);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnBuscarTurno);
            Controls.Add(cmbConsulta);
            Controls.Add(pictureBox1);
            Controls.Add(lblTurnosDisp);
            Controls.Add(btnRegistrarTurno);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(label1);
            Controls.Add(txtDniGestion);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(cmbMedico);
            Controls.Add(pictureBox8);
            Controls.Add(label2);
            Controls.Add(cmbEspecialidad);
            Controls.Add(pictureBox4);
            Controls.Add(dtpTurno);
            Controls.Add(picActividad);
            Controls.Add(picCantCuotasPA);
            Controls.Add(dgtvTurnos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GestionTurnos";
            Size = new Size(789, 513);
            ((System.ComponentModel.ISupportInitialize)dgtvTurnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCantCuotasPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgtvTurnos;
        private DateTimePicker dtpTurno;
        private PictureBox picActividad;
        private PictureBox picCantCuotasPA;
        private ComboBox cmbEspecialidad;
        private PictureBox pictureBox4;
        private Label label2;
        private ComboBox cmbMedico;
        private PictureBox pictureBox8;
        private Label label3;
        private TextBox txtDniGestion;
        private PictureBox pictureBox3;
        private Label label1;
        private CustomBotonDos btnBuscarPaciente;
        private CustomBotonDos btnRegistrarTurno;
        private Label lblTurnosDisp;
        private ComboBox cmbConsulta;
        private PictureBox pictureBox1;
        private CustomBotonDos btnBuscarTurno;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaDesde;
        private Label lblFechaHasta;
        private Label lblPractica;
    }
}
