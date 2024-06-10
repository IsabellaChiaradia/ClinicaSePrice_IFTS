namespace Dashboard_ClinicaSePrice
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            lblSingin = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            pnlControlPanel = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            btnLogin = new CustomBotonDos();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-5, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 525);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblSingin
            // 
            lblSingin.AutoSize = true;
            lblSingin.BackColor = Color.FromArgb(73, 162, 203);
            lblSingin.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblSingin.ForeColor = Color.White;
            lblSingin.Location = new Point(451, 146);
            lblSingin.Name = "lblSingin";
            lblSingin.Size = new Size(151, 54);
            lblSingin.TabIndex = 7;
            lblSingin.Text = "Sing in";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(73, 162, 203);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(423, 244);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(220, 19);
            txtUser.TabIndex = 11;
            txtUser.Text = "Usuario";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(73, 162, 203);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(423, 322);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 19);
            txtPassword.TabIndex = 12;
            txtPassword.Text = "Contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // pnlControlPanel
            // 
            pnlControlPanel.Controls.Add(btnClose);
            pnlControlPanel.Controls.Add(btnMinimize);
            pnlControlPanel.Location = new Point(531, 11);
            pnlControlPanel.Margin = new Padding(3, 2, 3, 2);
            pnlControlPanel.Name = "pnlControlPanel";
            pnlControlPanel.Size = new Size(161, 26);
            pnlControlPanel.TabIndex = 14;
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
            btnClose.Location = new Point(116, 1);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 23);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.BackgroundImage = (Image)resources.GetObject("btnMinimize.BackgroundImage");
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(67, 1);
            btnMinimize.Margin = new Padding(3, 2, 3, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(23, 23);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(29, 65, 81);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(440, 404);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(181, 39);
            btnLogin.TabIndex = 25;
            btnLogin.Text = "INICIAR SESION";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(412, 231);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(242, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(412, 311);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(242, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 162, 203);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 522);
            Controls.Add(txtUser);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogin);
            Controls.Add(pnlControlPanel);
            Controls.Add(txtPassword);
            Controls.Add(lblSingin);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Shown += Login_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblSingin;
        private LinkLabel linklblRecuperar;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Panel pnlControlPanel;
        private Button btnClose;
        private Button btnMinimize;
        private CustomBotonDos btnLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}