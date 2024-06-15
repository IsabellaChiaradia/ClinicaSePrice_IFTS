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
            dtgvHonorarios = new DataGridView();
            txtDNI = new TextBox();
            pictureBox3 = new PictureBox();
            btnBuscarMedico = new Dashboard_ClinicaSePrice.CustomBotonDos();
            ((System.ComponentModel.ISupportInitialize)dtgvHonorarios).BeginInit();
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
            btnCargarFactura.Click += btnCargarFactura_Click;
            // 
            // dtgvHonorarios
            // 
            dtgvHonorarios.AllowUserToAddRows = false;
            dtgvHonorarios.AllowUserToDeleteRows = false;
            dtgvHonorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHonorarios.BackgroundColor = Color.White;
            dtgvHonorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHonorarios.Location = new Point(14, 176);
            dtgvHonorarios.Margin = new Padding(3, 2, 3, 2);
            dtgvHonorarios.Name = "dtgvHonorarios";
            dtgvHonorarios.ReadOnly = true;
            dtgvHonorarios.RowTemplate.Height = 25;
            dtgvHonorarios.Size = new Size(738, 198);
            dtgvHonorarios.TabIndex = 77;
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.FromArgb(73, 162, 203);
            txtDNI.BorderStyle = BorderStyle.None;
            txtDNI.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.ForeColor = Color.White;
            txtDNI.Location = new Point(39, 83);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Multiline = true;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(214, 22);
            txtDNI.TabIndex = 81;
            txtDNI.Text = "DNI";
            txtDNI.Enter += txtDNI_Enter;
            txtDNI.KeyPress += txtDNI_KeyPress;
            txtDNI.Leave += txtDNI_Leave;
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
            // btnBuscarMedico
            // 
            btnBuscarMedico.BackColor = Color.FromArgb(29, 65, 81);
            btnBuscarMedico.Cursor = Cursors.Hand;
            btnBuscarMedico.FlatAppearance.BorderSize = 0;
            btnBuscarMedico.FlatStyle = FlatStyle.Flat;
            btnBuscarMedico.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarMedico.ForeColor = Color.White;
            btnBuscarMedico.Location = new Point(21, 119);
            btnBuscarMedico.Margin = new Padding(3, 2, 3, 2);
            btnBuscarMedico.Name = "btnBuscarMedico";
            btnBuscarMedico.Size = new Size(255, 39);
            btnBuscarMedico.TabIndex = 82;
            btnBuscarMedico.TabStop = false;
            btnBuscarMedico.Text = "BUSCAR";
            btnBuscarMedico.UseVisualStyleBackColor = false;
            btnBuscarMedico.Click += btnBuscarMedico_Click;
            // 
            // HonorariosMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            Controls.Add(btnBuscarMedico);
            Controls.Add(txtDNI);
            Controls.Add(pictureBox3);
            Controls.Add(btnPrintFactura);
            Controls.Add(btnCargarFactura);
            Controls.Add(dtgvHonorarios);
            Controls.Add(lblHonorarios);
            Name = "HonorariosMedicos";
            Size = new Size(789, 513);
            ((System.ComponentModel.ISupportInitialize)dtgvHonorarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHonorarios;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnPrintFactura;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnCargarFactura;
        private DataGridView dtgvHonorarios;
        private TextBox txtDNI;
        private PictureBox pictureBox3;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnBuscarMedico;
    }
}
