namespace ClinicaSePrice.Pages
{
    partial class PagoTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoTurnos));
            txtDniPaciente = new TextBox();
            picDocPA = new PictureBox();
            lblPA = new Label();
            cboFormaPago = new ComboBox();
            picFormaPago = new PictureBox();
            lblFormaPagoPA = new Label();
            btnComprobantePA = new Dashboard_ClinicaSePrice.CustomBotonDos();
            btnPagarPA = new Dashboard_ClinicaSePrice.CustomBotonDos();
            dtgvActividad = new DataGridView();
            txtMontoPA = new TextBox();
            picMontoPMC = new PictureBox();
            btnBuscarPaciente = new Dashboard_ClinicaSePrice.CustomBotonDos();
            ((System.ComponentModel.ISupportInitialize)picDocPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFormaPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMontoPMC).BeginInit();
            SuspendLayout();
            // 
            // txtDniPaciente
            // 
            txtDniPaciente.BackColor = Color.FromArgb(73, 162, 203);
            txtDniPaciente.BorderStyle = BorderStyle.None;
            txtDniPaciente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniPaciente.ForeColor = Color.White;
            txtDniPaciente.Location = new Point(51, 81);
            txtDniPaciente.Margin = new Padding(3, 2, 3, 2);
            txtDniPaciente.Multiline = true;
            txtDniPaciente.Name = "txtDniPaciente";
            txtDniPaciente.Size = new Size(176, 22);
            txtDniPaciente.TabIndex = 15;
            txtDniPaciente.Text = "DNI";
            txtDniPaciente.Enter += txtDniPaciente_Enter;
            txtDniPaciente.KeyPress += txtDniPaciente_KeyPress;
            txtDniPaciente.Leave += txtDniPaciente_Leave;
            // 
            // picDocPA
            // 
            picDocPA.BackColor = Color.FromArgb(73, 162, 203);
            picDocPA.Image = (Image)resources.GetObject("picDocPA.Image");
            picDocPA.Location = new Point(38, 70);
            picDocPA.Margin = new Padding(3, 2, 3, 2);
            picDocPA.Name = "picDocPA";
            picDocPA.Size = new Size(209, 43);
            picDocPA.SizeMode = PictureBoxSizeMode.StretchImage;
            picDocPA.TabIndex = 14;
            picDocPA.TabStop = false;
            // 
            // lblPA
            // 
            lblPA.AutoSize = true;
            lblPA.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblPA.ForeColor = Color.White;
            lblPA.Location = new Point(32, 26);
            lblPA.Name = "lblPA";
            lblPA.Size = new Size(179, 26);
            lblPA.TabIndex = 13;
            lblPA.Text = "Pago de Turnos";
            // 
            // cboFormaPago
            // 
            cboFormaPago.Cursor = Cursors.Hand;
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FlatStyle = FlatStyle.Popup;
            cboFormaPago.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboFormaPago.ForeColor = Color.FromArgb(74, 102, 174);
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(322, 78);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(176, 28);
            cboFormaPago.TabIndex = 31;
            // 
            // picFormaPago
            // 
            picFormaPago.BackgroundImage = (Image)resources.GetObject("picFormaPago.BackgroundImage");
            picFormaPago.BackgroundImageLayout = ImageLayout.Stretch;
            picFormaPago.Location = new Point(308, 70);
            picFormaPago.Name = "picFormaPago";
            picFormaPago.Size = new Size(206, 43);
            picFormaPago.TabIndex = 30;
            picFormaPago.TabStop = false;
            // 
            // lblFormaPagoPA
            // 
            lblFormaPagoPA.AutoSize = true;
            lblFormaPagoPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPagoPA.ForeColor = Color.White;
            lblFormaPagoPA.Location = new Point(306, 51);
            lblFormaPagoPA.Name = "lblFormaPagoPA";
            lblFormaPagoPA.Size = new Size(130, 20);
            lblFormaPagoPA.TabIndex = 27;
            lblFormaPagoPA.Text = "Forma de pago";
            // 
            // btnComprobantePA
            // 
            btnComprobantePA.BackColor = Color.FromArgb(29, 65, 81);
            btnComprobantePA.Cursor = Cursors.Hand;
            btnComprobantePA.Enabled = false;
            btnComprobantePA.FlatAppearance.BorderSize = 0;
            btnComprobantePA.FlatStyle = FlatStyle.Flat;
            btnComprobantePA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprobantePA.ForeColor = Color.White;
            btnComprobantePA.Location = new Point(589, 444);
            btnComprobantePA.Margin = new Padding(3, 2, 3, 2);
            btnComprobantePA.Name = "btnComprobantePA";
            btnComprobantePA.Size = new Size(181, 39);
            btnComprobantePA.TabIndex = 38;
            btnComprobantePA.Text = "COMPROBANTE";
            btnComprobantePA.UseVisualStyleBackColor = false;
            btnComprobantePA.Click += btnComprobantePA_Click;
            // 
            // btnPagarPA
            // 
            btnPagarPA.BackColor = Color.FromArgb(29, 65, 81);
            btnPagarPA.Cursor = Cursors.Hand;
            btnPagarPA.FlatAppearance.BorderSize = 0;
            btnPagarPA.FlatStyle = FlatStyle.Flat;
            btnPagarPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarPA.ForeColor = Color.White;
            btnPagarPA.Location = new Point(367, 444);
            btnPagarPA.Margin = new Padding(3, 2, 3, 2);
            btnPagarPA.Name = "btnPagarPA";
            btnPagarPA.Size = new Size(181, 39);
            btnPagarPA.TabIndex = 37;
            btnPagarPA.Text = "PAGAR";
            btnPagarPA.UseVisualStyleBackColor = false;
            btnPagarPA.Click += btnPagarPA_Click;
            // 
            // dtgvActividad
            // 
            dtgvActividad.AllowUserToAddRows = false;
            dtgvActividad.AllowUserToDeleteRows = false;
            dtgvActividad.BackgroundColor = Color.White;
            dtgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividad.Location = new Point(32, 185);
            dtgvActividad.Margin = new Padding(3, 2, 3, 2);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.ReadOnly = true;
            dtgvActividad.RowTemplate.Height = 25;
            dtgvActividad.Size = new Size(738, 238);
            dtgvActividad.TabIndex = 36;
            // 
            // txtMontoPA
            // 
            txtMontoPA.BackColor = Color.FromArgb(73, 162, 203);
            txtMontoPA.BorderStyle = BorderStyle.None;
            txtMontoPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoPA.ForeColor = Color.White;
            txtMontoPA.Location = new Point(574, 81);
            txtMontoPA.Margin = new Padding(3, 2, 3, 2);
            txtMontoPA.Multiline = true;
            txtMontoPA.Name = "txtMontoPA";
            txtMontoPA.ReadOnly = true;
            txtMontoPA.Size = new Size(176, 22);
            txtMontoPA.TabIndex = 42;
            txtMontoPA.Text = "Monto";
            // 
            // picMontoPMC
            // 
            picMontoPMC.BackColor = Color.FromArgb(73, 162, 203);
            picMontoPMC.Image = (Image)resources.GetObject("picMontoPMC.Image");
            picMontoPMC.Location = new Point(561, 69);
            picMontoPMC.Margin = new Padding(3, 2, 3, 2);
            picMontoPMC.Name = "picMontoPMC";
            picMontoPMC.Size = new Size(209, 43);
            picMontoPMC.SizeMode = PictureBoxSizeMode.StretchImage;
            picMontoPMC.TabIndex = 41;
            picMontoPMC.TabStop = false;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = Color.FromArgb(29, 65, 81);
            btnBuscarPaciente.Cursor = Cursors.Hand;
            btnBuscarPaciente.FlatAppearance.BorderSize = 0;
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPaciente.ForeColor = Color.White;
            btnBuscarPaciente.Location = new Point(38, 132);
            btnBuscarPaciente.Margin = new Padding(3, 2, 3, 2);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(212, 39);
            btnBuscarPaciente.TabIndex = 49;
            btnBuscarPaciente.Text = "BUSCAR PACIENTE";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // PagoTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(txtMontoPA);
            Controls.Add(picMontoPMC);
            Controls.Add(btnComprobantePA);
            Controls.Add(btnPagarPA);
            Controls.Add(dtgvActividad);
            Controls.Add(cboFormaPago);
            Controls.Add(picFormaPago);
            Controls.Add(lblFormaPagoPA);
            Controls.Add(txtDniPaciente);
            Controls.Add(picDocPA);
            Controls.Add(lblPA);
            Name = "PagoTurnos";
            Size = new Size(789, 513);
            Load += PagoTurno_Load;
            ((System.ComponentModel.ISupportInitialize)picDocPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFormaPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMontoPMC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDniPaciente;
        private PictureBox picDocPA;
        private Label lblPA;
        private ComboBox cboFormaPago;
        private PictureBox picFormaPago;
        private Label lblFormaPagoPA;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnComprobantePA;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnPagarPA;
        private DataGridView dtgvActividad;
        private TextBox txtMontoPA;
        private PictureBox picMontoPMC;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnBuscarPaciente;
    }
}
