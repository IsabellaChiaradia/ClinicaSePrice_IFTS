namespace ClinicaSePrice.Pages
{
    partial class CuotasVencidas
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
            lblCuotasVenc = new Label();
            btnNotificar = new Dashboard_ClinicaSePrice.CustomBotonDos();
            dtgvCuotasVenc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvCuotasVenc).BeginInit();
            SuspendLayout();
            // 
            // lblCuotasVenc
            // 
            lblCuotasVenc.AutoSize = true;
            lblCuotasVenc.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblCuotasVenc.ForeColor = Color.White;
            lblCuotasVenc.Location = new Point(32, 26);
            lblCuotasVenc.Name = "lblCuotasVenc";
            lblCuotasVenc.Size = new Size(186, 26);
            lblCuotasVenc.TabIndex = 14;
            lblCuotasVenc.Text = "Control Insumos";
            // 
            // btnNotificar
            // 
            btnNotificar.BackColor = Color.FromArgb(29, 65, 81);
            btnNotificar.Cursor = Cursors.Hand;
            btnNotificar.FlatAppearance.BorderSize = 0;
            btnNotificar.FlatStyle = FlatStyle.Flat;
            btnNotificar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNotificar.ForeColor = Color.White;
            btnNotificar.Location = new Point(581, 419);
            btnNotificar.Margin = new Padding(3, 2, 3, 2);
            btnNotificar.Name = "btnNotificar";
            btnNotificar.Size = new Size(181, 39);
            btnNotificar.TabIndex = 39;
            btnNotificar.Text = "NOTIFICAR";
            btnNotificar.UseVisualStyleBackColor = false;
            btnNotificar.Click += btnNotificar_Click;
            // 
            // dtgvCuotasVenc
            // 
            dtgvCuotasVenc.AllowUserToAddRows = false;
            dtgvCuotasVenc.AllowUserToDeleteRows = false;
            dtgvCuotasVenc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCuotasVenc.BackgroundColor = Color.White;
            dtgvCuotasVenc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCuotasVenc.Location = new Point(52, 103);
            dtgvCuotasVenc.Margin = new Padding(3, 2, 3, 2);
            dtgvCuotasVenc.Name = "dtgvCuotasVenc";
            dtgvCuotasVenc.ReadOnly = true;
            dtgvCuotasVenc.RowHeadersWidth = 51;
            dtgvCuotasVenc.RowTemplate.Height = 25;
            dtgvCuotasVenc.Size = new Size(710, 282);
            dtgvCuotasVenc.TabIndex = 41;
            // 
            // CuotasVencidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            Controls.Add(dtgvCuotasVenc);
            Controls.Add(btnNotificar);
            Controls.Add(lblCuotasVenc);
            Name = "CuotasVencidas";
            Size = new Size(789, 513);
            Load += CuotasVencidas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCuotasVenc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuotasVenc;
        private Dashboard_ClinicaSePrice.CustomBotonDos btnNotificar;
        private DataGridView dtgvCuotasVenc;
    }
}
