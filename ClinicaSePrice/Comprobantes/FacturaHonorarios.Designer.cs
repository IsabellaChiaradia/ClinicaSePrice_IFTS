namespace ClinicaSePrice.Comprobantes
{
    partial class frmFacturaHonorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaHonorarios));
            pictureBox1 = new PictureBox();
            btnVolver = new Dashboard_ClinicaSePrice.CustomBotonDos();
            btnImprimirFactura = new Dashboard_ClinicaSePrice.CustomBotonDos();
            lblMonto = new Label();
            lblCantTurnos = new Label();
            lblFechaPago = new Label();
            lblEspecialidad = new Label();
            lblDNI = new Label();
            lblNombreApe = new Label();
            lblTituloMonto = new Label();
            lblTituloCantTurnos = new Label();
            lblTituloFechaPago = new Label();
            lblTituloEspecialidad = new Label();
            lblTituloDNI = new Label();
            lblTituloNombreApe = new Label();
            lblFactura = new Label();
            lblClinicaSePrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 33);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(29, 65, 81);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(40, 473);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(181, 39);
            btnVolver.TabIndex = 62;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnImprimirFactura
            // 
            btnImprimirFactura.BackColor = Color.FromArgb(29, 65, 81);
            btnImprimirFactura.Cursor = Cursors.Hand;
            btnImprimirFactura.FlatAppearance.BorderSize = 0;
            btnImprimirFactura.FlatStyle = FlatStyle.Flat;
            btnImprimirFactura.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirFactura.ForeColor = Color.White;
            btnImprimirFactura.Location = new Point(276, 473);
            btnImprimirFactura.Margin = new Padding(3, 2, 3, 2);
            btnImprimirFactura.Name = "btnImprimirFactura";
            btnImprimirFactura.Size = new Size(181, 39);
            btnImprimirFactura.TabIndex = 61;
            btnImprimirFactura.Text = "IMPRIMIR";
            btnImprimirFactura.UseVisualStyleBackColor = false;
            btnImprimirFactura.Click += btnImprimirFactura_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = Color.White;
            lblMonto.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.Location = new Point(348, 421);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(58, 22);
            lblMonto.TabIndex = 60;
            lblMonto.Text = "label9";
            // 
            // lblCantTurnos
            // 
            lblCantTurnos.AutoSize = true;
            lblCantTurnos.BackColor = Color.White;
            lblCantTurnos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantTurnos.Location = new Point(211, 345);
            lblCantTurnos.Name = "lblCantTurnos";
            lblCantTurnos.Size = new Size(58, 22);
            lblCantTurnos.TabIndex = 58;
            lblCantTurnos.Text = "label7";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.BackColor = Color.White;
            lblFechaPago.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaPago.Location = new Point(169, 312);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(58, 22);
            lblFechaPago.TabIndex = 56;
            lblFechaPago.Text = "label5";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.BackColor = Color.White;
            lblEspecialidad.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecialidad.Location = new Point(154, 211);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(58, 22);
            lblEspecialidad.TabIndex = 54;
            lblEspecialidad.Text = "label3";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.White;
            lblDNI.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(82, 187);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(58, 22);
            lblDNI.TabIndex = 53;
            lblDNI.Text = "label2";
            // 
            // lblNombreApe
            // 
            lblNombreApe.AutoSize = true;
            lblNombreApe.BackColor = Color.White;
            lblNombreApe.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreApe.Location = new Point(201, 163);
            lblNombreApe.Name = "lblNombreApe";
            lblNombreApe.Size = new Size(58, 22);
            lblNombreApe.TabIndex = 52;
            lblNombreApe.Text = "label1";
            // 
            // lblTituloMonto
            // 
            lblTituloMonto.AutoSize = true;
            lblTituloMonto.BackColor = Color.White;
            lblTituloMonto.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloMonto.ForeColor = Color.FromArgb(73, 162, 203);
            lblTituloMonto.Location = new Point(276, 421);
            lblTituloMonto.Name = "lblTituloMonto";
            lblTituloMonto.Size = new Size(64, 22);
            lblTituloMonto.TabIndex = 51;
            lblTituloMonto.Text = "Monto:";
            // 
            // lblTituloCantTurnos
            // 
            lblTituloCantTurnos.AutoSize = true;
            lblTituloCantTurnos.BackColor = Color.White;
            lblTituloCantTurnos.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloCantTurnos.ForeColor = Color.FromArgb(73, 162, 203);
            lblTituloCantTurnos.Location = new Point(31, 345);
            lblTituloCantTurnos.Name = "lblTituloCantTurnos";
            lblTituloCantTurnos.Size = new Size(174, 22);
            lblTituloCantTurnos.TabIndex = 50;
            lblTituloCantTurnos.Text = "Cantidad de Turnos:";
            // 
            // lblTituloFechaPago
            // 
            lblTituloFechaPago.AutoSize = true;
            lblTituloFechaPago.BackColor = Color.White;
            lblTituloFechaPago.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloFechaPago.ForeColor = Color.FromArgb(73, 162, 203);
            lblTituloFechaPago.Location = new Point(31, 312);
            lblTituloFechaPago.Name = "lblTituloFechaPago";
            lblTituloFechaPago.Size = new Size(135, 22);
            lblTituloFechaPago.TabIndex = 47;
            lblTituloFechaPago.Text = "Fecha de pago:";
            // 
            // lblTituloEspecialidad
            // 
            lblTituloEspecialidad.AutoSize = true;
            lblTituloEspecialidad.BackColor = Color.White;
            lblTituloEspecialidad.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloEspecialidad.ForeColor = Color.FromArgb(73, 162, 203);
            lblTituloEspecialidad.Location = new Point(31, 211);
            lblTituloEspecialidad.Name = "lblTituloEspecialidad";
            lblTituloEspecialidad.Size = new Size(117, 22);
            lblTituloEspecialidad.TabIndex = 45;
            lblTituloEspecialidad.Text = "Especialidad:";
            // 
            // lblTituloDNI
            // 
            lblTituloDNI.AutoSize = true;
            lblTituloDNI.BackColor = Color.White;
            lblTituloDNI.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloDNI.ForeColor = Color.FromArgb(73, 162, 203);
            lblTituloDNI.Location = new Point(31, 187);
            lblTituloDNI.Name = "lblTituloDNI";
            lblTituloDNI.Size = new Size(45, 22);
            lblTituloDNI.TabIndex = 44;
            lblTituloDNI.Text = "DNI:";
            // 
            // lblTituloNombreApe
            // 
            lblTituloNombreApe.AutoSize = true;
            lblTituloNombreApe.BackColor = Color.White;
            lblTituloNombreApe.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloNombreApe.ForeColor = Color.FromArgb(73, 162, 203);
            lblTituloNombreApe.Location = new Point(31, 163);
            lblTituloNombreApe.Name = "lblTituloNombreApe";
            lblTituloNombreApe.Size = new Size(164, 22);
            lblTituloNombreApe.TabIndex = 43;
            lblTituloNombreApe.Text = "Nombre y apellido: ";
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.BackColor = Color.White;
            lblFactura.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblFactura.ForeColor = Color.FromArgb(73, 162, 203);
            lblFactura.Location = new Point(31, 124);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(355, 31);
            lblFactura.TabIndex = 42;
            lblFactura.Text = "Factura Honorarios Médicos";
            // 
            // lblClinicaSePrice
            // 
            lblClinicaSePrice.AutoSize = true;
            lblClinicaSePrice.BackColor = Color.White;
            lblClinicaSePrice.Enabled = false;
            lblClinicaSePrice.FlatStyle = FlatStyle.Flat;
            lblClinicaSePrice.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblClinicaSePrice.ForeColor = Color.FromArgb(73, 162, 203);
            lblClinicaSePrice.Location = new Point(143, 60);
            lblClinicaSePrice.Name = "lblClinicaSePrice";
            lblClinicaSePrice.Size = new Size(314, 31);
            lblClinicaSePrice.TabIndex = 40;
            lblClinicaSePrice.Text = "Clínica Médica SePrice";
            // 
            // frmFacturaHonorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 544);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimirFactura);
            Controls.Add(lblMonto);
            Controls.Add(lblCantTurnos);
            Controls.Add(lblFechaPago);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblDNI);
            Controls.Add(lblNombreApe);
            Controls.Add(lblTituloMonto);
            Controls.Add(lblTituloCantTurnos);
            Controls.Add(lblTituloFechaPago);
            Controls.Add(lblTituloEspecialidad);
            Controls.Add(lblTituloDNI);
            Controls.Add(lblTituloNombreApe);
            Controls.Add(lblFactura);
            Controls.Add(lblClinicaSePrice);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFacturaHonorarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FacturaHonorarios";
            Load += frmFacturaHonorarios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnVolver;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnImprimirFactura;
        private Label lblMonto;
        private Label lblCantTurnos;
        private Label lblFechaVenc;
        private Label lblFechaPago;
        private Label lblActividad;
        private Label lblEspecialidad;
        private Label lblDNI;
        private Label lblNombreApe;
        private Label lblTituloMonto;
        private Label lblTituloCantTurnos;
        private Label lblTituloFechaVenc;
        private Label lblTituloFechaPago;
        private Label lblTituloActividad;
        private Label lblTituloEspecialidad;
        private Label lblTituloDNI;
        private Label lblTituloNombreApe;
        private Label lblFactura;
        private Label lblClinicaSePrice;
    }
}