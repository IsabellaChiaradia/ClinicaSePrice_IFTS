namespace Dashboard_ClinicaSePrice
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            pnlControlPanel = new Panel();
            btnClose2 = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            btnRegistroPaciente = new Boton();
            btnControlinsumos = new Boton();
            btnPagoEstudio = new Boton();
            btnRegistroTurno = new Boton();
            panel2 = new Panel();
            lblNombreUser = new Label();
            label2 = new Label();
            label1 = new Label();
            customPanel1 = new CustomPanel();
            pnlContainer = new Panel();
            pnlControlPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlControlPanel
            // 
            pnlControlPanel.Controls.Add(btnClose2);
            pnlControlPanel.Controls.Add(btnClose);
            pnlControlPanel.Location = new Point(916, 9);
            pnlControlPanel.Margin = new Padding(3, 2, 3, 2);
            pnlControlPanel.Name = "pnlControlPanel";
            pnlControlPanel.Size = new Size(173, 26);
            pnlControlPanel.TabIndex = 0;
            // 
            // btnClose2
            // 
            btnClose2.BackColor = Color.Transparent;
            btnClose2.BackgroundImage = (Image)resources.GetObject("btnClose2.BackgroundImage");
            btnClose2.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose2.Cursor = Cursors.Hand;
            btnClose2.FlatAppearance.BorderSize = 0;
            btnClose2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose2.FlatStyle = FlatStyle.Flat;
            btnClose2.Location = new Point(149, 1);
            btnClose2.Margin = new Padding(3, 2, 3, 2);
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new Size(22, 23);
            btnClose2.TabIndex = 2;
            btnClose2.UseVisualStyleBackColor = false;
            btnClose2.Click += btnClose2_Click;
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
            btnClose.Location = new Point(105, 1);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(23, 23);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(btnRegistroPaciente);
            panel1.Controls.Add(btnControlinsumos);
            panel1.Controls.Add(btnPagoEstudio);
            panel1.Controls.Add(btnRegistroTurno);
            panel1.Location = new Point(-3, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 698);
            panel1.TabIndex = 1;
            // 
            // btnRegistroPaciente
            // 
            btnRegistroPaciente.BackColor = Color.FromArgb(73, 162, 203);
            btnRegistroPaciente.BackgroundImageLayout = ImageLayout.None;
            btnRegistroPaciente.Cursor = Cursors.Hand;
            btnRegistroPaciente.FlatAppearance.BorderSize = 0;
            btnRegistroPaciente.FlatStyle = FlatStyle.Flat;
            btnRegistroPaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistroPaciente.ForeColor = Color.White;
            btnRegistroPaciente.Location = new Point(34, 177);
            btnRegistroPaciente.Name = "btnRegistroPaciente";
            btnRegistroPaciente.Padding = new Padding(30, 0, 0, 0);
            btnRegistroPaciente.Size = new Size(203, 52);
            btnRegistroPaciente.TabIndex = 6;
            btnRegistroPaciente.Text = "Registrar Paciente";
            btnRegistroPaciente.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroPaciente.UseVisualStyleBackColor = false;
            btnRegistroPaciente.Click += btnRegistroPaciente_Click;
            // 
            // btnControlinsumos
            // 
            btnControlinsumos.BackColor = Color.FromArgb(73, 162, 203);
            btnControlinsumos.BackgroundImageLayout = ImageLayout.None;
            btnControlinsumos.Cursor = Cursors.Hand;
            btnControlinsumos.FlatAppearance.BorderSize = 0;
            btnControlinsumos.FlatStyle = FlatStyle.Flat;
            btnControlinsumos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnControlinsumos.ForeColor = Color.White;
            btnControlinsumos.Location = new Point(34, 435);
            btnControlinsumos.Name = "btnControlinsumos";
            btnControlinsumos.Padding = new Padding(20, 0, 0, 0);
            btnControlinsumos.Size = new Size(203, 52);
            btnControlinsumos.TabIndex = 5;
            btnControlinsumos.Text = "Control de Insumos";
            btnControlinsumos.TextAlign = ContentAlignment.MiddleLeft;
            btnControlinsumos.UseVisualStyleBackColor = false;
            btnControlinsumos.Click += btnControlinsumos_Click;
            // 
            // btnPagoEstudio
            // 
            btnPagoEstudio.BackColor = Color.FromArgb(73, 162, 203);
            btnPagoEstudio.BackgroundImageLayout = ImageLayout.None;
            btnPagoEstudio.Cursor = Cursors.Hand;
            btnPagoEstudio.FlatAppearance.BorderSize = 0;
            btnPagoEstudio.FlatStyle = FlatStyle.Flat;
            btnPagoEstudio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagoEstudio.ForeColor = Color.White;
            btnPagoEstudio.Location = new Point(34, 349);
            btnPagoEstudio.Name = "btnPagoEstudio";
            btnPagoEstudio.Padding = new Padding(20, 0, 0, 0);
            btnPagoEstudio.Size = new Size(203, 52);
            btnPagoEstudio.TabIndex = 4;
            btnPagoEstudio.Text = "Pago de Turnos";
            btnPagoEstudio.TextAlign = ContentAlignment.MiddleLeft;
            btnPagoEstudio.UseVisualStyleBackColor = false;
            btnPagoEstudio.Click += btnPagoEstudio_Click;
            // 
            // btnRegistroTurno
            // 
            btnRegistroTurno.BackColor = Color.FromArgb(73, 162, 203);
            btnRegistroTurno.BackgroundImageLayout = ImageLayout.None;
            btnRegistroTurno.Cursor = Cursors.Hand;
            btnRegistroTurno.FlatAppearance.BorderSize = 0;
            btnRegistroTurno.FlatStyle = FlatStyle.Flat;
            btnRegistroTurno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistroTurno.ForeColor = Color.White;
            btnRegistroTurno.Location = new Point(34, 262);
            btnRegistroTurno.Name = "btnRegistroTurno";
            btnRegistroTurno.Padding = new Padding(30, 0, 0, 0);
            btnRegistroTurno.Size = new Size(203, 52);
            btnRegistroTurno.TabIndex = 2;
            btnRegistroTurno.Text = "Gestion Turnos";
            btnRegistroTurno.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistroTurno.UseVisualStyleBackColor = false;
            btnRegistroTurno.Click += btnRegistroTurno_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblNombreUser);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(273, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 77);
            panel2.TabIndex = 2;
            // 
            // lblNombreUser
            // 
            lblNombreUser.AutoSize = true;
            lblNombreUser.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUser.ForeColor = SystemColors.ButtonHighlight;
            lblNombreUser.Location = new Point(141, 53);
            lblNombreUser.Name = "lblNombreUser";
            lblNombreUser.Size = new Size(185, 20);
            lblNombreUser.TabIndex = 2;
            lblNombreUser.Text = "NOMBRE DE USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 53);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Bienvenido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(37, 8);
            label1.Name = "label1";
            label1.Size = new Size(270, 25);
            label1.TabIndex = 0;
            label1.Text = "Panel de control general";
            // 
            // customPanel1
            // 
            customPanel1.Location = new Point(271, 128);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(818, 493);
            customPanel1.TabIndex = 3;
            // 
            // pnlContainer
            // 
            pnlContainer.Location = new Point(273, 130);
            pnlContainer.Margin = new Padding(3, 2, 3, 2);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(813, 489);
            pnlContainer.TabIndex = 0;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1120, 648);
            Controls.Add(pnlContainer);
            Controls.Add(customPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlControlPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlControlPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlControlPanel;
        private Button btnClose;
        private Button btnClose2;
        private Panel panel1;
        private Boton btnRegistroTurno;
        private Boton btnControlinsumos;
        private Boton btnPagoEstudio;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label lblNombreUser;
        private CustomPanel customPanel1;
        private Panel pnlContainer;
        private Boton btnRegistroPaciente;
    }
}