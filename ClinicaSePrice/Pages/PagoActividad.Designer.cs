namespace ClinicaSePrice.Pages
{
    partial class PagoActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoActividad));
            txtDocumentoPA = new TextBox();
            picDocPA = new PictureBox();
            lblPA = new Label();
            cboCuotasPA = new ComboBox();
            picCantCuotasPA = new PictureBox();
            cbxTarjetaPA = new CheckBox();
            cbxEfectivoPA = new CheckBox();
            lblFormaPagoPA = new Label();
            btnComprobantePA = new Dashboard_ClinicaSePrice.CustomBotonDos();
            btnPagarPA = new Dashboard_ClinicaSePrice.CustomBotonDos();
            dtgvActividad = new DataGridView();
            dtpPA = new DateTimePicker();
            picActividad = new PictureBox();
            cboActividad = new ComboBox();
            pictureBox1 = new PictureBox();
            txtMontoPA = new TextBox();
            picMontoPMC = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDocPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCantCuotasPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMontoPMC).BeginInit();
            SuspendLayout();
            // 
            // txtDocumentoPA
            // 
            txtDocumentoPA.BackColor = Color.FromArgb(74, 102, 174);
            txtDocumentoPA.BorderStyle = BorderStyle.None;
            txtDocumentoPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumentoPA.ForeColor = Color.White;
            txtDocumentoPA.Location = new Point(50, 86);
            txtDocumentoPA.Margin = new Padding(3, 2, 3, 2);
            txtDocumentoPA.Multiline = true;
            txtDocumentoPA.Name = "txtDocumentoPA";
            txtDocumentoPA.Size = new Size(214, 22);
            txtDocumentoPA.TabIndex = 15;
            txtDocumentoPA.Text = "Documento";
            txtDocumentoPA.Enter += txtDocumentoPA_Enter;
            txtDocumentoPA.KeyPress += txtDocumentoPA_KeyPress;
            txtDocumentoPA.Leave += txtDocumentoPA_Leave;
            // 
            // picDocPA
            // 
            picDocPA.Image = (Image)resources.GetObject("picDocPA.Image");
            picDocPA.Location = new Point(6, 76);
            picDocPA.Margin = new Padding(3, 2, 3, 2);
            picDocPA.Name = "picDocPA";
            picDocPA.Size = new Size(304, 43);
            picDocPA.SizeMode = PictureBoxSizeMode.Zoom;
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
            lblPA.Size = new Size(202, 26);
            lblPA.TabIndex = 13;
            lblPA.Text = "Pago de actividad";
            // 
            // cboCuotasPA
            // 
            cboCuotasPA.Cursor = Cursors.Hand;
            cboCuotasPA.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotasPA.Enabled = false;
            cboCuotasPA.FlatStyle = FlatStyle.Popup;
            cboCuotasPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCuotasPA.ForeColor = Color.FromArgb(74, 102, 174);
            cboCuotasPA.FormattingEnabled = true;
            cboCuotasPA.Location = new Point(51, 406);
            cboCuotasPA.Name = "cboCuotasPA";
            cboCuotasPA.Size = new Size(217, 28);
            cboCuotasPA.TabIndex = 31;
            cboCuotasPA.SelectedIndexChanged += cboCuotasPA_SelectedIndexChanged;
            // 
            // picCantCuotasPA
            // 
            picCantCuotasPA.BackgroundImage = (Image)resources.GetObject("picCantCuotasPA.BackgroundImage");
            picCantCuotasPA.BackgroundImageLayout = ImageLayout.Stretch;
            picCantCuotasPA.Location = new Point(37, 398);
            picCantCuotasPA.Name = "picCantCuotasPA";
            picCantCuotasPA.Size = new Size(247, 43);
            picCantCuotasPA.TabIndex = 30;
            picCantCuotasPA.TabStop = false;
            // 
            // cbxTarjetaPA
            // 
            cbxTarjetaPA.AutoSize = true;
            cbxTarjetaPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTarjetaPA.ForeColor = Color.White;
            cbxTarjetaPA.Location = new Point(54, 353);
            cbxTarjetaPA.Margin = new Padding(3, 2, 3, 2);
            cbxTarjetaPA.Name = "cbxTarjetaPA";
            cbxTarjetaPA.Size = new Size(151, 24);
            cbxTarjetaPA.TabIndex = 29;
            cbxTarjetaPA.Text = "Tarjeta de crédito";
            cbxTarjetaPA.UseVisualStyleBackColor = true;
            cbxTarjetaPA.CheckedChanged += cbxTarjetaPA_CheckedChanged;
            // 
            // cbxEfectivoPA
            // 
            cbxEfectivoPA.AutoSize = true;
            cbxEfectivoPA.Checked = true;
            cbxEfectivoPA.CheckState = CheckState.Checked;
            cbxEfectivoPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxEfectivoPA.ForeColor = Color.White;
            cbxEfectivoPA.Location = new Point(54, 308);
            cbxEfectivoPA.Margin = new Padding(3, 2, 3, 2);
            cbxEfectivoPA.Name = "cbxEfectivoPA";
            cbxEfectivoPA.Size = new Size(85, 24);
            cbxEfectivoPA.TabIndex = 28;
            cbxEfectivoPA.Text = "Efectivo";
            cbxEfectivoPA.UseVisualStyleBackColor = true;
            cbxEfectivoPA.CheckedChanged += cbxEfectivoPA_CheckedChanged;
            // 
            // lblFormaPagoPA
            // 
            lblFormaPagoPA.AutoSize = true;
            lblFormaPagoPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPagoPA.ForeColor = Color.White;
            lblFormaPagoPA.Location = new Point(49, 266);
            lblFormaPagoPA.Name = "lblFormaPagoPA";
            lblFormaPagoPA.Size = new Size(130, 20);
            lblFormaPagoPA.TabIndex = 27;
            lblFormaPagoPA.Text = "Forma de pago";
            // 
            // btnComprobantePA
            // 
            btnComprobantePA.BackColor = Color.FromArgb(96, 61, 140);
            btnComprobantePA.Cursor = Cursors.Hand;
            btnComprobantePA.Enabled = false;
            btnComprobantePA.FlatAppearance.BorderSize = 0;
            btnComprobantePA.FlatStyle = FlatStyle.Flat;
            btnComprobantePA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprobantePA.ForeColor = Color.White;
            btnComprobantePA.Location = new Point(588, 402);
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
            btnPagarPA.BackColor = Color.FromArgb(96, 61, 140);
            btnPagarPA.Cursor = Cursors.Hand;
            btnPagarPA.FlatAppearance.BorderSize = 0;
            btnPagarPA.FlatStyle = FlatStyle.Flat;
            btnPagarPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagarPA.ForeColor = Color.White;
            btnPagarPA.Location = new Point(361, 402);
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
            dtgvActividad.Location = new Point(362, 189);
            dtgvActividad.Margin = new Padding(3, 2, 3, 2);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.ReadOnly = true;
            dtgvActividad.RowTemplate.Height = 25;
            dtgvActividad.Size = new Size(408, 196);
            dtgvActividad.TabIndex = 36;
            // 
            // dtpPA
            // 
            dtpPA.CalendarForeColor = Color.Black;
            dtpPA.CalendarTitleForeColor = Color.FromArgb(74, 102, 174);
            dtpPA.Cursor = Cursors.Hand;
            dtpPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPA.Format = DateTimePickerFormat.Short;
            dtpPA.Location = new Point(379, 86);
            dtpPA.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpPA.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpPA.Name = "dtpPA";
            dtpPA.Size = new Size(215, 26);
            dtpPA.TabIndex = 34;
            // 
            // picActividad
            // 
            picActividad.BackgroundImage = (Image)resources.GetObject("picActividad.BackgroundImage");
            picActividad.BackgroundImageLayout = ImageLayout.Stretch;
            picActividad.Location = new Point(362, 78);
            picActividad.Name = "picActividad";
            picActividad.Size = new Size(247, 43);
            picActividad.TabIndex = 33;
            picActividad.TabStop = false;
            // 
            // cboActividad
            // 
            cboActividad.Cursor = Cursors.Hand;
            cboActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividad.FlatStyle = FlatStyle.Popup;
            cboActividad.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboActividad.ForeColor = Color.FromArgb(74, 102, 174);
            cboActividad.FormattingEnabled = true;
            cboActividad.Location = new Point(54, 209);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(217, 28);
            cboActividad.TabIndex = 40;
            cboActividad.SelectedIndexChanged += cboActividad_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(40, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 43);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // txtMontoPA
            // 
            txtMontoPA.BackColor = Color.FromArgb(74, 102, 174);
            txtMontoPA.BorderStyle = BorderStyle.None;
            txtMontoPA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoPA.ForeColor = Color.White;
            txtMontoPA.Location = new Point(50, 147);
            txtMontoPA.Margin = new Padding(3, 2, 3, 2);
            txtMontoPA.Multiline = true;
            txtMontoPA.Name = "txtMontoPA";
            txtMontoPA.ReadOnly = true;
            txtMontoPA.Size = new Size(214, 22);
            txtMontoPA.TabIndex = 42;
            txtMontoPA.Text = "Monto";
            // 
            // picMontoPMC
            // 
            picMontoPMC.Image = (Image)resources.GetObject("picMontoPMC.Image");
            picMontoPMC.Location = new Point(6, 136);
            picMontoPMC.Margin = new Padding(3, 2, 3, 2);
            picMontoPMC.Name = "picMontoPMC";
            picMontoPMC.Size = new Size(304, 43);
            picMontoPMC.SizeMode = PictureBoxSizeMode.Zoom;
            picMontoPMC.TabIndex = 41;
            picMontoPMC.TabStop = false;
            // 
            // PagoActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 102, 174);
            Controls.Add(txtMontoPA);
            Controls.Add(picMontoPMC);
            Controls.Add(cboActividad);
            Controls.Add(pictureBox1);
            Controls.Add(btnComprobantePA);
            Controls.Add(btnPagarPA);
            Controls.Add(dtgvActividad);
            Controls.Add(dtpPA);
            Controls.Add(picActividad);
            Controls.Add(cboCuotasPA);
            Controls.Add(picCantCuotasPA);
            Controls.Add(cbxTarjetaPA);
            Controls.Add(cbxEfectivoPA);
            Controls.Add(lblFormaPagoPA);
            Controls.Add(txtDocumentoPA);
            Controls.Add(picDocPA);
            Controls.Add(lblPA);
            Name = "PagoActividad";
            Size = new Size(789, 513);
            Load += PagoActividad_Load;
            ((System.ComponentModel.ISupportInitialize)picDocPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCantCuotasPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMontoPMC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDocumentoPA;
        private PictureBox picDocPA;
        private Label lblPA;
        private ComboBox cboCuotasPA;
        private PictureBox picCantCuotasPA;
        private CheckBox cbxTarjetaPA;
        private CheckBox cbxEfectivoPA;
        private Label lblFormaPagoPA;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnComprobantePA;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnPagarPA;
        private DataGridView dtgvActividad;
        private DateTimePicker dtpPA;
        private PictureBox picActividad;
        private ComboBox cboActividad;
        private PictureBox pictureBox1;
        private TextBox txtMontoPA;
        private PictureBox picMontoPMC;
    }
}
