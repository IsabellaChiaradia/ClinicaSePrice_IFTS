namespace ClinicaSePrice.Pages
{
    partial class ControlInsumos
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
            dtgvControlInsumos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvControlInsumos).BeginInit();
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
            // dtgvControlInsumos
            // 
            dtgvControlInsumos.AllowUserToAddRows = false;
            dtgvControlInsumos.AllowUserToDeleteRows = false;
            dtgvControlInsumos.AllowUserToResizeColumns = false;
            dtgvControlInsumos.AllowUserToResizeRows = false;
            dtgvControlInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvControlInsumos.BackgroundColor = Color.White;
            dtgvControlInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvControlInsumos.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dtgvControlInsumos.Location = new Point(52, 103);
            dtgvControlInsumos.Margin = new Padding(3, 2, 3, 2);
            dtgvControlInsumos.Name = "dtgvControlInsumos";
            dtgvControlInsumos.ReadOnly = true;
            dtgvControlInsumos.RowHeadersWidth = 51;
            dtgvControlInsumos.RowTemplate.Height = 25;
            dtgvControlInsumos.Size = new Size(710, 282);
            dtgvControlInsumos.TabIndex = 41;
            // 
            // ControlInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            Controls.Add(dtgvControlInsumos);
            Controls.Add(lblCuotasVenc);
            Name = "ControlInsumos";
            Size = new Size(789, 513);
            Load += ControlInsumos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvControlInsumos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuotasVenc;
        private DataGridView dtgvControlInsumos;
    }
}
