namespace ClinicaSePrice.Comprobantes
{
    partial class FormComprobanteTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprobanteTurno));
            lblNombre = new Label();
            lblDni = new Label();
            lblClinicaSePrice2 = new Label();
            lblNombreSocio = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblDniSocio = new Label();
            lblIDsocio = new Label();
            lblMail = new Label();
            lblFecha = new Label();
            panel1 = new Panel();
            pictureQr = new PictureBox();
            btnImprimirCarnet = new Dashboard_ClinicaSePrice.CustomBotonDos();
            btnVolver = new Dashboard_ClinicaSePrice.CustomBotonDos();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureQr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 15);
            lblNombre.TabIndex = 0;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(84, 184);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(0, 15);
            lblDni.TabIndex = 1;
            // 
            // lblClinicaSePrice2
            // 
            lblClinicaSePrice2.AutoSize = true;
            lblClinicaSePrice2.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblClinicaSePrice2.ForeColor = Color.FromArgb(73, 162, 203);
            lblClinicaSePrice2.Location = new Point(186, 74);
            lblClinicaSePrice2.Name = "lblClinicaSePrice2";
            lblClinicaSePrice2.Size = new Size(313, 31);
            lblClinicaSePrice2.TabIndex = 6;
            lblClinicaSePrice2.Text = "Comprobante de Turno";
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.AutoSize = true;
            lblNombreSocio.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreSocio.ForeColor = Color.FromArgb(73, 162, 203);
            lblNombreSocio.Location = new Point(15, 130);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(110, 31);
            lblNombreSocio.TabIndex = 7;
            lblNombreSocio.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 162, 203);
            label1.Location = new Point(20, 211);
            label1.Name = "label1";
            label1.Size = new Size(45, 22);
            label1.TabIndex = 8;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(73, 162, 203);
            label2.Location = new Point(20, 241);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 9;
            label2.Text = "Médico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(73, 162, 203);
            label3.Location = new Point(20, 268);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 10;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(73, 162, 203);
            label4.Location = new Point(20, 296);
            label4.Name = "label4";
            label4.Size = new Size(123, 22);
            label4.TabIndex = 11;
            label4.Text = "Fecha y Hora:";
            // 
            // lblDniSocio
            // 
            lblDniSocio.AutoSize = true;
            lblDniSocio.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDniSocio.Location = new Point(74, 211);
            lblDniSocio.Name = "lblDniSocio";
            lblDniSocio.Size = new Size(58, 22);
            lblDniSocio.TabIndex = 13;
            lblDniSocio.Text = "label1";
            // 
            // lblIDsocio
            // 
            lblIDsocio.AutoSize = true;
            lblIDsocio.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDsocio.Location = new Point(186, 241);
            lblIDsocio.Name = "lblIDsocio";
            lblIDsocio.Size = new Size(58, 22);
            lblIDsocio.TabIndex = 14;
            lblIDsocio.Text = "label1";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(99, 268);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(58, 22);
            lblMail.TabIndex = 15;
            lblMail.Text = "label1";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(215, 296);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 22);
            lblFecha.TabIndex = 16;
            lblFecha.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureQr);
            panel1.Controls.Add(btnImprimirCarnet);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblMail);
            panel1.Controls.Add(lblIDsocio);
            panel1.Controls.Add(lblDniSocio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNombreSocio);
            panel1.Controls.Add(lblClinicaSePrice2);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(23, 25);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 414);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // pictureQr
            // 
            pictureQr.BackgroundImageLayout = ImageLayout.Stretch;
            pictureQr.Location = new Point(362, 203);
            pictureQr.Margin = new Padding(3, 2, 3, 2);
            pictureQr.Name = "pictureQr";
            pictureQr.Size = new Size(131, 112);
            pictureQr.TabIndex = 37;
            pictureQr.TabStop = false;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.BackColor = Color.FromArgb(29, 65, 81);
            btnImprimirCarnet.Cursor = Cursors.Hand;
            btnImprimirCarnet.FlatAppearance.BorderSize = 0;
            btnImprimirCarnet.FlatStyle = FlatStyle.Flat;
            btnImprimirCarnet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirCarnet.ForeColor = Color.White;
            btnImprimirCarnet.Location = new Point(293, 354);
            btnImprimirCarnet.Margin = new Padding(3, 2, 3, 2);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(181, 39);
            btnImprimirCarnet.TabIndex = 36;
            btnImprimirCarnet.Text = "IMPRIMIR";
            btnImprimirCarnet.UseVisualStyleBackColor = false;
            btnImprimirCarnet.Click += btnImprimirFactura_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(29, 65, 81);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(20, 354);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(181, 39);
            btnVolver.TabIndex = 35;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 464);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCarnet";
            Text = "FormCarnet";
            Load += FormCarnet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureQr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblDni;
        private Label lblClinicaSePrice2;
        private Label lblNombreSocio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblDniSocio;
        private Label lblIDsocio;
        private Label lblMail;
        private Label lblFecha;
        private Panel panel1;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnVolver;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnImprimirCarnet;
        private PictureBox pictureQr;
        private PictureBox pictureBox1;
    }
}