namespace PRL.User_Interfaces
{
    partial class LichChieu
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
            label3 = new Label();
            dtg_HienThiLichChieu = new DataGridView();
            txt_giochieu = new TextBox();
            pictureBox5 = new PictureBox();
            btn_TaoLich = new Button();
            btn_SuaLich = new Button();
            btn_UpdateTT = new Button();
            txt_ngaychieu = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            cbo_phongchieu = new ComboBox();
            cbo_maphim = new ComboBox();
            label5 = new Label();
            txt_malc = new TextBox();
            Panel_lichChieu = new Panel();
            btn_xoalich = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_HienThiLichChieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            Panel_lichChieu.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 49;
            label3.Text = "Lịch Chiếu";
            // 
            // dtg_HienThiLichChieu
            // 
            dtg_HienThiLichChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_HienThiLichChieu.BackgroundColor = Color.White;
            dtg_HienThiLichChieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HienThiLichChieu.Location = new Point(8, 394);
            dtg_HienThiLichChieu.Margin = new Padding(3, 2, 3, 2);
            dtg_HienThiLichChieu.Name = "dtg_HienThiLichChieu";
            dtg_HienThiLichChieu.RowHeadersWidth = 51;
            dtg_HienThiLichChieu.RowTemplate.Height = 29;
            dtg_HienThiLichChieu.Size = new Size(913, 294);
            dtg_HienThiLichChieu.TabIndex = 0;
            dtg_HienThiLichChieu.CellClick += dtg_HienThiLichChieu_CellClick;
            // 
            // txt_giochieu
            // 
            txt_giochieu.BackColor = Color.FromArgb(255, 138, 0);
            txt_giochieu.BorderStyle = BorderStyle.None;
            txt_giochieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_giochieu.ForeColor = Color.Black;
            txt_giochieu.Location = new Point(116, 141);
            txt_giochieu.Margin = new Padding(3, 4, 3, 4);
            txt_giochieu.Name = "txt_giochieu";
            txt_giochieu.Size = new Size(282, 27);
            txt_giochieu.TabIndex = 71;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(651, 70);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(181, 260);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 58;
            pictureBox5.TabStop = false;
            // 
            // btn_TaoLich
            // 
            btn_TaoLich.BackColor = Color.FromArgb(112, 88, 61);
            btn_TaoLich.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_TaoLich.ForeColor = Color.White;
            btn_TaoLich.Location = new Point(651, 352);
            btn_TaoLich.Margin = new Padding(3, 2, 3, 2);
            btn_TaoLich.Name = "btn_TaoLich";
            btn_TaoLich.Size = new Size(181, 38);
            btn_TaoLich.TabIndex = 57;
            btn_TaoLich.Text = "Tạo Lịch Chiếu";
            btn_TaoLich.UseVisualStyleBackColor = false;
            btn_TaoLich.Click += btn_TaoLich_Click;
            // 
            // btn_SuaLich
            // 
            btn_SuaLich.BackColor = Color.FromArgb(112, 88, 61);
            btn_SuaLich.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SuaLich.ForeColor = Color.White;
            btn_SuaLich.Location = new Point(49, 323);
            btn_SuaLich.Margin = new Padding(3, 2, 3, 2);
            btn_SuaLich.Name = "btn_SuaLich";
            btn_SuaLich.Size = new Size(171, 38);
            btn_SuaLich.TabIndex = 57;
            btn_SuaLich.Text = "Sửa Lịch Chiếu";
            btn_SuaLich.UseVisualStyleBackColor = false;
            btn_SuaLich.Click += btn_SuaLich_Click;
            // 
            // btn_UpdateTT
            // 
            btn_UpdateTT.BackColor = Color.FromArgb(112, 88, 61);
            btn_UpdateTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateTT.ForeColor = Color.White;
            btn_UpdateTT.Location = new Point(226, 323);
            btn_UpdateTT.Margin = new Padding(3, 2, 3, 2);
            btn_UpdateTT.Name = "btn_UpdateTT";
            btn_UpdateTT.Size = new Size(111, 38);
            btn_UpdateTT.TabIndex = 55;
            btn_UpdateTT.Text = "Cập Nhật";
            btn_UpdateTT.UseVisualStyleBackColor = false;
            btn_UpdateTT.Click += btn_UpdateTT_Click;
            // 
            // txt_ngaychieu
            // 
            txt_ngaychieu.BackColor = Color.FromArgb(255, 138, 0);
            txt_ngaychieu.BorderStyle = BorderStyle.None;
            txt_ngaychieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ngaychieu.ForeColor = Color.Black;
            txt_ngaychieu.Location = new Point(116, 104);
            txt_ngaychieu.Margin = new Padding(3, 4, 3, 4);
            txt_ngaychieu.Name = "txt_ngaychieu";
            txt_ngaychieu.Size = new Size(282, 27);
            txt_ngaychieu.TabIndex = 68;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 171);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 49;
            label4.Text = "Phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(47, 139);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 49;
            label2.Text = "Giờ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 102);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 49;
            label1.Text = "Ngày:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 67);
            label7.Name = "label7";
            label7.Size = new Size(73, 32);
            label7.TabIndex = 49;
            label7.Text = "Phim:";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbo_phongchieu);
            panel1.Controls.Add(cbo_maphim);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_malc);
            panel1.Controls.Add(txt_giochieu);
            panel1.Controls.Add(txt_ngaychieu);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(49, 70);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 227);
            panel1.TabIndex = 50;
            // 
            // cbo_phongchieu
            // 
            cbo_phongchieu.BackColor = Color.FromArgb(255, 138, 0);
            cbo_phongchieu.FormattingEnabled = true;
            cbo_phongchieu.Location = new Point(116, 177);
            cbo_phongchieu.Name = "cbo_phongchieu";
            cbo_phongchieu.Size = new Size(283, 28);
            cbo_phongchieu.TabIndex = 78;
            // 
            // cbo_maphim
            // 
            cbo_maphim.BackColor = Color.FromArgb(255, 138, 0);
            cbo_maphim.FormattingEnabled = true;
            cbo_maphim.Location = new Point(116, 69);
            cbo_maphim.Name = "cbo_maphim";
            cbo_maphim.Size = new Size(282, 28);
            cbo_maphim.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 35);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 76;
            label5.Text = "Mã:";
            // 
            // txt_malc
            // 
            txt_malc.BackColor = Color.FromArgb(255, 138, 0);
            txt_malc.BorderStyle = BorderStyle.None;
            txt_malc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_malc.ForeColor = Color.Black;
            txt_malc.Location = new Point(116, 34);
            txt_malc.Margin = new Padding(3, 4, 3, 4);
            txt_malc.Name = "txt_malc";
            txt_malc.Size = new Size(282, 27);
            txt_malc.TabIndex = 75;
            // 
            // Panel_lichChieu
            // 
            Panel_lichChieu.Controls.Add(btn_xoalich);
            Panel_lichChieu.Controls.Add(pictureBox5);
            Panel_lichChieu.Controls.Add(btn_TaoLich);
            Panel_lichChieu.Controls.Add(btn_SuaLich);
            Panel_lichChieu.Controls.Add(btn_UpdateTT);
            Panel_lichChieu.Controls.Add(panel1);
            Panel_lichChieu.Controls.Add(label3);
            Panel_lichChieu.Controls.Add(dtg_HienThiLichChieu);
            Panel_lichChieu.Location = new Point(2, 0);
            Panel_lichChieu.Margin = new Padding(3, 2, 3, 2);
            Panel_lichChieu.Name = "Panel_lichChieu";
            Panel_lichChieu.Size = new Size(923, 940);
            Panel_lichChieu.TabIndex = 1;
            // 
            // btn_xoalich
            // 
            btn_xoalich.BackColor = Color.FromArgb(112, 88, 61);
            btn_xoalich.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoalich.ForeColor = Color.White;
            btn_xoalich.Location = new Point(343, 323);
            btn_xoalich.Margin = new Padding(3, 2, 3, 2);
            btn_xoalich.Name = "btn_xoalich";
            btn_xoalich.Size = new Size(124, 38);
            btn_xoalich.TabIndex = 59;
            btn_xoalich.Text = "Xóa lịch";
            btn_xoalich.UseVisualStyleBackColor = false;
            btn_xoalich.Click += btn_xoalich_Click;
            // 
            // LichChieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(937, 714);
            Controls.Add(Panel_lichChieu);
            Name = "LichChieu";
            Text = "LichChieu";
            ((System.ComponentModel.ISupportInitialize)dtg_HienThiLichChieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Panel_lichChieu.ResumeLayout(false);
            Panel_lichChieu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private DataGridView dtg_HienThiLichChieu;
        private TextBox txt_giochieu;
        private PictureBox pictureBox5;
        private Button btn_TaoLich;
        private Button btn_SuaLich;
        private Button btn_UpdateTT;
        private TextBox txt_ngaychieu;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
        private Panel panel1;
        private Panel Panel_lichChieu;
        private Label label5;
        private TextBox txt_malc;
        private ComboBox cbo_maphim;
        private ComboBox cbo_phongchieu;
        private Button btn_xoalich;
    }
}