namespace PRL.User_Interfaces
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel_login = new Panel();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            txtMK = new TextBox();
            pictureBox1 = new PictureBox();
            txtTK = new TextBox();
            label3 = new Label();
            panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.FromArgb(190, 0, 0);
            panel_login.Controls.Add(btnLogin);
            panel_login.Controls.Add(pictureBox2);
            panel_login.Controls.Add(txtMK);
            panel_login.Controls.Add(pictureBox1);
            panel_login.Controls.Add(txtTK);
            panel_login.Controls.Add(label3);
            panel_login.Location = new Point(0, 0);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(355, 320);
            panel_login.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(114, 221);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(217, 217, 217);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(277, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // txtMK
            // 
            txtMK.BackColor = Color.FromArgb(217, 217, 217);
            txtMK.Font = new Font("Cascadia Mono SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtMK.ForeColor = SystemColors.Control;
            txtMK.Location = new Point(50, 154);
            txtMK.Margin = new Padding(4, 3, 4, 3);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.PlaceholderText = "Mật khẩu";
            txtMK.Size = new Size(264, 39);
            txtMK.TabIndex = 57;
            txtMK.KeyDown += txtMK_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 217, 217);
            pictureBox1.Location = new Point(277, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // txtTK
            // 
            txtTK.BackColor = Color.FromArgb(217, 217, 217);
            txtTK.Font = new Font("Cascadia Mono SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTK.ForeColor = SystemColors.Control;
            txtTK.Location = new Point(50, 87);
            txtTK.Margin = new Padding(4, 3, 4, 3);
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Tài khoản";
            txtTK.Size = new Size(264, 39);
            txtTK.TabIndex = 55;
            txtTK.KeyDown += txtTK_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 23);
            label3.Name = "label3";
            label3.Size = new Size(200, 46);
            label3.TabIndex = 52;
            label3.Text = "Đăng Nhập";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 317);
            Controls.Add(panel_login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            KeyDown += Login_KeyDown;
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_login;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private TextBox txtMK;
        private PictureBox pictureBox1;
        private TextBox txtTK;
        private Label label3;
    }
}