namespace ClinicaSePrice.Pages
{
    partial class RegistroPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPaciente));
            pnlControlPanel = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            lblFechaNac = new Label();
            btnLimpiar = new Dashboard_ClinicaSePrice.CustomBotonDos();
            txtFechaNacimiento = new TextBox();
            txtDomicilio = new TextBox();
            txtCorreo = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtNombre = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlControlPanel
            // 
            pnlControlPanel.Controls.Add(btnClose);
            pnlControlPanel.Controls.Add(btnMinimize);
            pnlControlPanel.Location = new Point(616, 11);
            pnlControlPanel.Margin = new Padding(3, 2, 3, 2);
            pnlControlPanel.Name = "pnlControlPanel";
            pnlControlPanel.Size = new Size(161, 26);
            pnlControlPanel.TabIndex = 15;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(116, 1);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 23);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(67, 1);
            btnMinimize.Margin = new Padding(3, 2, 3, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(23, 23);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNac.ForeColor = Color.White;
            lblFechaNac.Location = new Point(36, 348);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(157, 20);
            lblFechaNac.TabIndex = 45;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(29, 65, 81);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(27, 445);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(181, 39);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.BackColor = Color.FromArgb(73, 162, 203);
            txtFechaNacimiento.BorderStyle = BorderStyle.None;
            txtFechaNacimiento.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaNacimiento.ForeColor = Color.White;
            txtFechaNacimiento.Location = new Point(45, 381);
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
            txtDomicilio.Location = new Point(45, 306);
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
            txtCorreo.Location = new Point(45, 251);
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
            txtDni.Location = new Point(45, 193);
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
            txtApellido.Location = new Point(45, 134);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(214, 22);
            txtApellido.TabIndex = 37;
            txtApellido.Text = "Apellido";
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(27, 241);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(255, 43);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 36;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(27, 296);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(255, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(27, 370);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(255, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 182);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(255, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 124);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(255, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 68);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(73, 162, 203);
            label1.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(201, 26);
            label1.TabIndex = 29;
            label1.Text = "Registro Paciente";
            // 
            // RegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            ClientSize = new Size(789, 513);
            Controls.Add(lblFechaNac);
            Controls.Add(btnLimpiar);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtDomicilio);
            Controls.Add(txtCorreo);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pnlControlPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistroPaciente";
            Text = "RegistroPaciente";
            pnlControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlControlPanel;
        private Button btnClose;
        private Button btnMinimize;
        private Label lblFechaNac;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnLimpiar;
        private TextBox txtFechaNacimiento;
        private TextBox txtDomicilio;
        private TextBox txtCorreo;
        private TextBox txtDni;
        private TextBox txtApellido;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtNombre;
        private PictureBox pictureBox1;
        private Label label1;
    }
}