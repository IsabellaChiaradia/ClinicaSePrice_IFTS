namespace ClinicaSePrice.Pages
{
    partial class HonorariosMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HonorariosMedicos));
            lblHonorarios = new Label();
            btnPrintFactura = new Dashboard_ClinicaSePrice.CustomBotonDos();
            btnCargarFactura = new Dashboard_ClinicaSePrice.CustomBotonDos();
            dtgvActividad = new DataGridView();
            cmbTipoLiquidacion = new ComboBox();
            picFormaPago = new PictureBox();
            lblTipoLiquidacion = new Label();
            txtDniGestion = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFormaPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblHonorarios
            // 
            lblHonorarios.AutoSize = true;
            lblHonorarios.BackColor = Color.FromArgb(73, 162, 203);
            lblHonorarios.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblHonorarios.ForeColor = Color.White;
            lblHonorarios.Location = new Point(14, 29);
            lblHonorarios.Name = "lblHonorarios";
            lblHonorarios.Size = new Size(223, 26);
            lblHonorarios.TabIndex = 70;
            lblHonorarios.Text = "Honorarios Médicos";
            // 
            // btnPrintFactura
            // 
            btnPrintFactura.BackColor = Color.FromArgb(29, 65, 81);
            btnPrintFactura.Cursor = Cursors.Hand;
            btnPrintFactura.Enabled = false;
            btnPrintFactura.FlatAppearance.BorderSize = 0;
            btnPrintFactura.FlatStyle = FlatStyle.Flat;
            btnPrintFactura.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintFactura.ForeColor = Color.White;
            btnPrintFactura.Location = new Point(343, 404);
            btnPrintFactura.Margin = new Padding(3, 2, 3, 2);
            btnPrintFactura.Name = "btnPrintFactura";
            btnPrintFactura.Size = new Size(181, 39);
            btnPrintFactura.TabIndex = 79;
            btnPrintFactura.Text = "IMPRIMIR";
            btnPrintFactura.UseVisualStyleBackColor = false;
            // 
            // btnCargarFactura
            // 
            btnCargarFactura.BackColor = Color.FromArgb(29, 65, 81);
            btnCargarFactura.Cursor = Cursors.Hand;
            btnCargarFactura.FlatAppearance.BorderSize = 0;
            btnCargarFactura.FlatStyle = FlatStyle.Flat;
            btnCargarFactura.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarFactura.ForeColor = Color.White;
            btnCargarFactura.Location = new Point(570, 404);
            btnCargarFactura.Margin = new Padding(3, 2, 3, 2);
            btnCargarFactura.Name = "btnCargarFactura";
            btnCargarFactura.Size = new Size(181, 39);
            btnCargarFactura.TabIndex = 78;
            btnCargarFactura.Text = "CARGAR FACTURA";
            btnCargarFactura.UseVisualStyleBackColor = false;
            // 
            // dtgvActividad
            // 
            dtgvActividad.AllowUserToAddRows = false;
            dtgvActividad.AllowUserToDeleteRows = false;
            dtgvActividad.BackgroundColor = Color.White;
            dtgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividad.Location = new Point(14, 136);
            dtgvActividad.Margin = new Padding(3, 2, 3, 2);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.ReadOnly = true;
            dtgvActividad.RowTemplate.Height = 25;
            dtgvActividad.Size = new Size(738, 238);
            dtgvActividad.TabIndex = 77;
            // 
            // cmbTipoLiquidacion
            // 
            cmbTipoLiquidacion.Cursor = Cursors.Hand;
            cmbTipoLiquidacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoLiquidacion.Enabled = false;
            cmbTipoLiquidacion.FlatStyle = FlatStyle.Popup;
            cmbTipoLiquidacion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoLiquidacion.ForeColor = Color.FromArgb(74, 102, 174);
            cmbTipoLiquidacion.FormattingEnabled = true;
            cmbTipoLiquidacion.Location = new Point(343, 83);
            cmbTipoLiquidacion.Name = "cmbTipoLiquidacion";
            cmbTipoLiquidacion.Size = new Size(232, 28);
            cmbTipoLiquidacion.TabIndex = 76;
            // 
            // picFormaPago
            // 
            picFormaPago.BackgroundImage = (Image)resources.GetObject("picFormaPago.BackgroundImage");
            picFormaPago.BackgroundImageLayout = ImageLayout.Stretch;
            picFormaPago.Location = new Point(329, 75);
            picFormaPago.Name = "picFormaPago";
            picFormaPago.Size = new Size(262, 43);
            picFormaPago.TabIndex = 75;
            picFormaPago.TabStop = false;
            // 
            // lblTipoLiquidacion
            // 
            lblTipoLiquidacion.AutoSize = true;
            lblTipoLiquidacion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoLiquidacion.ForeColor = Color.White;
            lblTipoLiquidacion.Location = new Point(327, 56);
            lblTipoLiquidacion.Name = "lblTipoLiquidacion";
            lblTipoLiquidacion.Size = new Size(164, 20);
            lblTipoLiquidacion.TabIndex = 74;
            lblTipoLiquidacion.Text = "Tipo de Liquidación";
            // 
            // txtDniGestion
            // 
            txtDniGestion.BackColor = Color.FromArgb(73, 162, 203);
            txtDniGestion.BorderStyle = BorderStyle.None;
            txtDniGestion.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniGestion.ForeColor = Color.White;
            txtDniGestion.Location = new Point(39, 83);
            txtDniGestion.Margin = new Padding(3, 2, 3, 2);
            txtDniGestion.Multiline = true;
            txtDniGestion.Name = "txtDniGestion";
            txtDniGestion.Size = new Size(214, 22);
            txtDniGestion.TabIndex = 81;
            txtDniGestion.Text = "DNI";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(73, 162, 203);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 72);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(255, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 80;
            pictureBox3.TabStop = false;
            // 
            // HonorariosMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            Controls.Add(txtDniGestion);
            Controls.Add(pictureBox3);
            Controls.Add(btnPrintFactura);
            Controls.Add(btnCargarFactura);
            Controls.Add(dtgvActividad);
            Controls.Add(cmbTipoLiquidacion);
            Controls.Add(picFormaPago);
            Controls.Add(lblTipoLiquidacion);
            Controls.Add(lblHonorarios);
            Name = "HonorariosMedicos";
            Size = new Size(789, 513);
            Load += HonorariosMedicos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFormaPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHonorarios;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnPrintFactura;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnCargarFactura;
        private DataGridView dtgvActividad;
        private ComboBox cmbTipoLiquidacion;
        private PictureBox picFormaPago;
        private Label lblTipoLiquidacion;
        private TextBox txtDniGestion;
        private PictureBox pictureBox3;
    }
}
