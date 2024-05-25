namespace Dashboard_ClinicaSePrice.Pages
{
    partial class PagoMensualCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoMensualCuota));
            lblPMC = new Label();
            txtMonto = new TextBox();
            picMontoPMC = new PictureBox();
            txtDni = new TextBox();
            picDocPMC = new PictureBox();
            lblFormaPago = new Label();
            cbxEfectivo = new CheckBox();
            cbxTarjeta = new CheckBox();
            picCantCuotas = new PictureBox();
            cboCuotas = new ComboBox();
            pictureBox2 = new PictureBox();
            dtpPago = new DateTimePicker();
            lblTotal = new Label();
            dgtvPagoRealizado = new DataGridView();
            btnPagar = new CustomBotonDos();
            btnComprobante = new CustomBotonDos();
            ((System.ComponentModel.ISupportInitialize)picMontoPMC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDocPMC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCantCuotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgtvPagoRealizado).BeginInit();
            SuspendLayout();
            // 
            // lblPMC
            // 
            lblPMC.AutoSize = true;
            lblPMC.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblPMC.ForeColor = Color.White;
            lblPMC.Location = new Point(32, 26);
            lblPMC.Name = "lblPMC";
            lblPMC.Size = new Size(229, 26);
            lblPMC.TabIndex = 0;
            lblPMC.Text = "Pago mensual cuota";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = Color.FromArgb(74, 102, 174);
            txtMonto.BorderStyle = BorderStyle.None;
            txtMonto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.ForeColor = Color.White;
            txtMonto.Location = new Point(50, 153);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Multiline = true;
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(214, 22);
            txtMonto.TabIndex = 13;
            txtMonto.Text = "Monto";
            txtMonto.Enter += txtMonto_Enter;
            txtMonto.KeyPress += txtMonto_KeyPress;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // picMontoPMC
            // 
            picMontoPMC.Image = (Image)resources.GetObject("picMontoPMC.Image");
            picMontoPMC.Location = new Point(6, 143);
            picMontoPMC.Margin = new Padding(3, 2, 3, 2);
            picMontoPMC.Name = "picMontoPMC";
            picMontoPMC.Size = new Size(304, 43);
            picMontoPMC.SizeMode = PictureBoxSizeMode.Zoom;
            picMontoPMC.TabIndex = 11;
            picMontoPMC.TabStop = false;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.FromArgb(74, 102, 174);
            txtDni.BorderStyle = BorderStyle.None;
            txtDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.White;
            txtDni.Location = new Point(50, 86);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(214, 22);
            txtDni.TabIndex = 12;
            txtDni.Text = "Documento";
            txtDni.Enter += txtDni_Enter;
            txtDni.KeyPress += txtDni_KeyPress;
            txtDni.Leave += txtDni_Leave;
            // 
            // picDocPMC
            // 
            picDocPMC.Image = (Image)resources.GetObject("picDocPMC.Image");
            picDocPMC.Location = new Point(6, 76);
            picDocPMC.Margin = new Padding(3, 2, 3, 2);
            picDocPMC.Name = "picDocPMC";
            picDocPMC.Size = new Size(304, 43);
            picDocPMC.SizeMode = PictureBoxSizeMode.Zoom;
            picDocPMC.TabIndex = 10;
            picDocPMC.TabStop = false;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPago.ForeColor = Color.White;
            lblFormaPago.Location = new Point(44, 251);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(130, 20);
            lblFormaPago.TabIndex = 14;
            lblFormaPago.Text = "Forma de pago";
            // 
            // cbxEfectivo
            // 
            cbxEfectivo.AutoSize = true;
            cbxEfectivo.Checked = true;
            cbxEfectivo.CheckState = CheckState.Checked;
            cbxEfectivo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxEfectivo.ForeColor = Color.White;
            cbxEfectivo.Location = new Point(49, 293);
            cbxEfectivo.Margin = new Padding(3, 2, 3, 2);
            cbxEfectivo.Name = "cbxEfectivo";
            cbxEfectivo.Size = new Size(85, 24);
            cbxEfectivo.TabIndex = 23;
            cbxEfectivo.Text = "Efectivo";
            cbxEfectivo.UseVisualStyleBackColor = true;
            cbxEfectivo.CheckedChanged += cbxEfectivo_CheckedChanged;
            // 
            // cbxTarjeta
            // 
            cbxTarjeta.AutoSize = true;
            cbxTarjeta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTarjeta.ForeColor = Color.White;
            cbxTarjeta.Location = new Point(49, 338);
            cbxTarjeta.Margin = new Padding(3, 2, 3, 2);
            cbxTarjeta.Name = "cbxTarjeta";
            cbxTarjeta.Size = new Size(151, 24);
            cbxTarjeta.TabIndex = 24;
            cbxTarjeta.Text = "Tarjeta de crédito";
            cbxTarjeta.UseVisualStyleBackColor = true;
            cbxTarjeta.CheckedChanged += cbxTarjeta_CheckedChanged;
            // 
            // picCantCuotas
            // 
            picCantCuotas.BackgroundImage = (Image)resources.GetObject("picCantCuotas.BackgroundImage");
            picCantCuotas.BackgroundImageLayout = ImageLayout.Stretch;
            picCantCuotas.Location = new Point(44, 391);
            picCantCuotas.Name = "picCantCuotas";
            picCantCuotas.Size = new Size(247, 43);
            picCantCuotas.TabIndex = 25;
            picCantCuotas.TabStop = false;
            // 
            // cboCuotas
            // 
            cboCuotas.Cursor = Cursors.Hand;
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.Enabled = false;
            cboCuotas.FlatStyle = FlatStyle.Popup;
            cboCuotas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCuotas.ForeColor = Color.FromArgb(74, 102, 174);
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(58, 399);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(217, 28);
            cboCuotas.TabIndex = 26;
            cboCuotas.SelectedIndexChanged += cboCuotas_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(362, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 43);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // dtpPago
            // 
            dtpPago.CalendarForeColor = Color.Black;
            dtpPago.CalendarTitleForeColor = Color.FromArgb(74, 102, 174);
            dtpPago.Cursor = Cursors.Hand;
            dtpPago.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPago.Format = DateTimePickerFormat.Short;
            dtpPago.Location = new Point(379, 86);
            dtpPago.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpPago.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpPago.Name = "dtpPago";
            dtpPago.Size = new Size(215, 26);
            dtpPago.TabIndex = 28;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(362, 157);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(157, 20);
            lblTotal.TabIndex = 29;
            lblTotal.Text = "Total con descuento:";
            // 
            // dgtvPagoRealizado
            // 
            dgtvPagoRealizado.AllowUserToAddRows = false;
            dgtvPagoRealizado.AllowUserToDeleteRows = false;
            dgtvPagoRealizado.BackgroundColor = Color.White;
            dgtvPagoRealizado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvPagoRealizado.Location = new Point(362, 189);
            dgtvPagoRealizado.Margin = new Padding(3, 2, 3, 2);
            dgtvPagoRealizado.Name = "dgtvPagoRealizado";
            dgtvPagoRealizado.ReadOnly = true;
            dgtvPagoRealizado.RowTemplate.Height = 25;
            dgtvPagoRealizado.Size = new Size(408, 174);
            dgtvPagoRealizado.TabIndex = 30;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(96, 61, 140);
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(362, 395);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(181, 39);
            btnPagar.TabIndex = 31;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.FromArgb(96, 61, 140);
            btnComprobante.Cursor = Cursors.Hand;
            btnComprobante.Enabled = false;
            btnComprobante.FlatAppearance.BorderSize = 0;
            btnComprobante.FlatStyle = FlatStyle.Flat;
            btnComprobante.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprobante.ForeColor = Color.White;
            btnComprobante.Location = new Point(589, 395);
            btnComprobante.Margin = new Padding(3, 2, 3, 2);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(181, 39);
            btnComprobante.TabIndex = 32;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // PagoMensualCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 102, 174);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(dgtvPagoRealizado);
            Controls.Add(lblTotal);
            Controls.Add(dtpPago);
            Controls.Add(pictureBox2);
            Controls.Add(cboCuotas);
            Controls.Add(picCantCuotas);
            Controls.Add(cbxTarjeta);
            Controls.Add(cbxEfectivo);
            Controls.Add(lblFormaPago);
            Controls.Add(txtMonto);
            Controls.Add(picMontoPMC);
            Controls.Add(txtDni);
            Controls.Add(picDocPMC);
            Controls.Add(lblPMC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PagoMensualCuota";
            Size = new Size(789, 513);
            Load += PagoMensualCuota_Load;
            ((System.ComponentModel.ISupportInitialize)picMontoPMC).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDocPMC).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCantCuotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgtvPagoRealizado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMonto;
        private PictureBox picMontoPMC;
        private TextBox txtDni;
        private PictureBox picDocPMC;
        private Label lblFormaPago;
        private CheckBox cbxEfectivo;
        private CheckBox cbxTarjeta;
        private Label lblPMC;
        private PictureBox pictureBox1;
        private PictureBox picCantCuotas;
        private ComboBox cboCuotas;
        private PictureBox pictureBox2;
        private DateTimePicker dtpPago;
        private Label lblTotal;
        private DataGridView dgtvPagoRealizado;
        private CustomBotonDos btnPagar;
        private CustomBotonDos btnComprobante;
    }
}
