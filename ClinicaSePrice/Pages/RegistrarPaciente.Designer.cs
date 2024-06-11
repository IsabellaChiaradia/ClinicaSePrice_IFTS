namespace ClinicaSePrice.Pages
{
    partial class RegistrarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPaciente));
            lblFechaNac = new Label();
            txtFechaNacimiento = new TextBox();
            txtDomicilio = new TextBox();
            txtCorreo = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            picDocPA = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            bntLimpiarRP = new Dashboard_ClinicaSePrice.CustomBotonDos();
            dgtvDatosPaciente = new DataGridView();
            btnRegistrar = new Dashboard_ClinicaSePrice.CustomBotonDos();
            ((System.ComponentModel.ISupportInitialize)picDocPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgtvDatosPaciente).BeginInit();
            SuspendLayout();
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.ForeColor = Color.White;
            lblFechaNac.Location = new Point(36, 342);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(157, 20);
            lblFechaNac.TabIndex = 45;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.BackColor = Color.FromArgb(73, 162, 203);
            txtFechaNacimiento.BorderStyle = BorderStyle.None;
            txtFechaNacimiento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaNacimiento.ForeColor = Color.White;
            txtFechaNacimiento.Location = new Point(45, 375);
            txtFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            txtFechaNacimiento.MaxLength = 10;
            txtFechaNacimiento.Multiline = true;
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(214, 22);
            txtFechaNacimiento.TabIndex = 41;
            txtFechaNacimiento.Text = "dd/mm/aaaa";
            txtFechaNacimiento.Enter += txtFechaNacimiento_Enter;
            txtFechaNacimiento.Leave += txtFechaNacimiento_Leave;
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.FromArgb(73, 162, 203);
            txtDomicilio.BorderStyle = BorderStyle.None;
            txtDomicilio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDomicilio.ForeColor = Color.White;
            txtDomicilio.Location = new Point(45, 301);
            txtDomicilio.Margin = new Padding(3, 2, 3, 2);
            txtDomicilio.Multiline = true;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(214, 22);
            txtDomicilio.TabIndex = 40;
            txtDomicilio.Text = "Domicilio";
            txtDomicilio.Enter += txtDomicilio_Enter;
            txtDomicilio.Leave += txtDomicilio_Leave;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(73, 162, 203);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(45, 244);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(214, 22);
            txtCorreo.TabIndex = 39;
            txtCorreo.Text = "Correo";
            txtCorreo.Enter += txtCorreo_Enter;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(73, 162, 203);
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.White;
            txtDni.Location = new Point(45, 189);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(214, 22);
            txtDni.TabIndex = 38;
            txtDni.Text = "DNI";
            txtDni.Enter += txtDni_Enter;
            txtDni.KeyPress += txtDni_KeyPress;
            txtDni.Leave += txtDni_Leave;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(73, 162, 203);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(45, 132);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(214, 22);
            txtApellido.TabIndex = 37;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(73, 162, 203);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(45, 78);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 22);
            txtNombre.TabIndex = 35;
            txtNombre.Text = "Nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(73, 162, 203);
            label1.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(201, 26);
            label1.TabIndex = 29;
            label1.Text = "Registro Paciente";
            // 
            // picDocPA
            // 
            picDocPA.BackColor = Color.FromArgb(73, 162, 203);
            picDocPA.Image = (Image)resources.GetObject("picDocPA.Image");
            picDocPA.Location = new Point(27, 68);
            picDocPA.Margin = new Padding(3, 2, 3, 2);
            picDocPA.Name = "picDocPA";
            picDocPA.Size = new Size(247, 43);
            picDocPA.SizeMode = PictureBoxSizeMode.StretchImage;
            picDocPA.TabIndex = 46;
            picDocPA.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 122);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 178);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 234);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(27, 290);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(247, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(27, 364);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(247, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 51;
            pictureBox5.TabStop = false;
            // 
            // bntLimpiarRP
            // 
            bntLimpiarRP.BackColor = Color.FromArgb(29, 65, 81);
            bntLimpiarRP.Cursor = Cursors.Hand;
            bntLimpiarRP.FlatAppearance.BorderSize = 0;
            bntLimpiarRP.FlatStyle = FlatStyle.Flat;
            bntLimpiarRP.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bntLimpiarRP.ForeColor = Color.White;
            bntLimpiarRP.Location = new Point(27, 428);
            bntLimpiarRP.Margin = new Padding(3, 2, 3, 2);
            bntLimpiarRP.Name = "bntLimpiarRP";
            bntLimpiarRP.Size = new Size(181, 39);
            bntLimpiarRP.TabIndex = 52;
            bntLimpiarRP.Text = "LIMPIAR";
            bntLimpiarRP.UseVisualStyleBackColor = false;
            bntLimpiarRP.Click += bntLimpiarRP_Click;
            // 
            // dgtvDatosPaciente
            // 
            dgtvDatosPaciente.AllowUserToAddRows = false;
            dgtvDatosPaciente.AllowUserToDeleteRows = false;
            dgtvDatosPaciente.BackgroundColor = Color.White;
            dgtvDatosPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvDatosPaciente.Location = new Point(319, 68);
            dgtvDatosPaciente.Margin = new Padding(3, 2, 3, 2);
            dgtvDatosPaciente.Name = "dgtvDatosPaciente";
            dgtvDatosPaciente.ReadOnly = true;
            dgtvDatosPaciente.RowHeadersWidth = 51;
            dgtvDatosPaciente.RowTemplate.Height = 29;
            dgtvDatosPaciente.Size = new Size(448, 339);
            dgtvDatosPaciente.TabIndex = 53;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(29, 65, 81);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(586, 428);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(181, 39);
            btnRegistrar.TabIndex = 55;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // RegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            Controls.Add(btnRegistrar);
            Controls.Add(dgtvDatosPaciente);
            Controls.Add(bntLimpiarRP);
            Controls.Add(lblFechaNac);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtDomicilio);
            Controls.Add(txtCorreo);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(picDocPA);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Name = "RegistrarPaciente";
            Size = new Size(789, 513);
            ((System.ComponentModel.ISupportInitialize)picDocPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgtvDatosPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFechaNac;
        private TextBox txtFechaNacimiento;
        private TextBox txtDomicilio;
        private TextBox txtCorreo;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label1;
        private PictureBox picDocPA;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Dashboard_ClinicaSePrice.CustomBotonDos bntLimpiarRP;
        private DataGridView dgtvDatosPaciente;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnRegistrar;
    }
}