﻿namespace PRL.User_Interfaces
{
    partial class ThongKe
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
            panel_Thongke = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDoanhThuDichVuNgay = new TextBox();
            txtDoanhThuPhim = new TextBox();
            txtSoVeBan = new TextBox();
            label3 = new Label();
            dgvThongKe = new DataGridView();
            panel_Thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel_Thongke
            // 
            panel_Thongke.Controls.Add(label4);
            panel_Thongke.Controls.Add(label2);
            panel_Thongke.Controls.Add(label1);
            panel_Thongke.Controls.Add(txtDoanhThuDichVuNgay);
            panel_Thongke.Controls.Add(txtDoanhThuPhim);
            panel_Thongke.Controls.Add(txtSoVeBan);
            panel_Thongke.Controls.Add(label3);
            panel_Thongke.Controls.Add(dgvThongKe);
            panel_Thongke.Location = new Point(2, 1);
            panel_Thongke.Margin = new Padding(3, 2, 3, 2);
            panel_Thongke.Name = "panel_Thongke";
            panel_Thongke.Size = new Size(808, 752);
            panel_Thongke.TabIndex = 1;
            // 

            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Firebrick;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(20, 643);
            label4.Name = "label4";
            label4.Size = new Size(292, 32);
            label4.TabIndex = 58;
            label4.Text = "Doanh Thu Dịch Vụ Ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Firebrick;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(20, 579);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 57;
            label2.Text = "Doanh Thu Phim Ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(20, 514);
            label1.Name = "label1";
            label1.Size = new Size(325, 32);
            label1.TabIndex = 56;
            label1.Text = "Số lượng vé bán trong ngày :";
            // 
            // txtDoanhThuDichVuNgay
            // 
            txtDoanhThuDichVuNgay.BackColor = Color.FromArgb(255, 188, 18);
            txtDoanhThuDichVuNgay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoanhThuDichVuNgay.Location = new Point(365, 640);
            txtDoanhThuDichVuNgay.Multiline = true;
            txtDoanhThuDichVuNgay.Name = "txtDoanhThuDichVuNgay";
            txtDoanhThuDichVuNgay.Size = new Size(538, 46);
            txtDoanhThuDichVuNgay.TabIndex = 55;
            // 
            // txtDoanhThuPhim
            // 
            txtDoanhThuPhim.BackColor = Color.FromArgb(255, 188, 18);
            txtDoanhThuPhim.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoanhThuPhim.Location = new Point(365, 576);
            txtDoanhThuPhim.Multiline = true;
            txtDoanhThuPhim.Name = "txtDoanhThuPhim";
            txtDoanhThuPhim.Size = new Size(538, 46);
            txtDoanhThuPhim.TabIndex = 54;
            // 
            // txtSoVeBan
            // 
            txtSoVeBan.BackColor = Color.FromArgb(255, 188, 18);
            txtSoVeBan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoVeBan.Location = new Point(365, 511);
            txtSoVeBan.Multiline = true;
            txtSoVeBan.Name = "txtSoVeBan";
            txtSoVeBan.Size = new Size(538, 46);
            txtSoVeBan.TabIndex = 54;
=======

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;

            label3.Location = new Point(225, 8);
=======

            label3.Name = "label3";
            label3.Size = new Size(385, 25);
            label3.TabIndex = 49;
            label3.Text = "Doanh Thu Trong Ngày Và  Số Lượng Vé Bán";
            // 
            // dgvThongKe
            // 

            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.BackgroundColor = Color.White;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(0, 71);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.RowTemplate.Height = 29;
            dgvThongKe.Size = new Size(917, 418);
            dgvThongKe.TabIndex = 0;
            dgvThongKe.CellClick += dgvThongKe_CellClick;
=======

            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(815, 571);
            Controls.Add(panel_Thongke);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongKe";
            Text = "ThongKe";
            Load += ThongKe_Load;
            panel_Thongke.ResumeLayout(false);
            panel_Thongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Thongke;
        private TextBox txtDoanhThuPhim;
        private TextBox txtSoVeBan;
        private Label label3;
        private DataGridView dgvThongKe;
        private TextBox txtDoanhThuDichVuNgay;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}