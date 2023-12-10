namespace PRL.User_Interfaces
{
    partial class YeuCauDichVu
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
            panel_YeuCauDichVu = new Panel();
            lb_TongGiaTien = new Label();
            textBox1 = new TextBox();
            btn_ThanhToan = new Button();
            label3 = new Label();
            dtg_ChonDV = new DataGridView();
            dtg_HienThiDSDV = new DataGridView();
            panel_YeuCauDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ChonDV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_HienThiDSDV).BeginInit();
            SuspendLayout();
            // 
            // panel_YeuCauDichVu
            // 
            panel_YeuCauDichVu.Controls.Add(lb_TongGiaTien);
            panel_YeuCauDichVu.Controls.Add(textBox1);
            panel_YeuCauDichVu.Controls.Add(btn_ThanhToan);
            panel_YeuCauDichVu.Controls.Add(label3);
            panel_YeuCauDichVu.Controls.Add(dtg_ChonDV);
            panel_YeuCauDichVu.Controls.Add(dtg_HienThiDSDV);
            panel_YeuCauDichVu.Location = new Point(2, 0);
            panel_YeuCauDichVu.Name = "panel_YeuCauDichVu";
            panel_YeuCauDichVu.Size = new Size(923, 940);
            panel_YeuCauDichVu.TabIndex = 2;
            // 
            // lb_TongGiaTien
            // 
            lb_TongGiaTien.AutoSize = true;
            lb_TongGiaTien.BackColor = Color.FromArgb(255, 188, 18);
            lb_TongGiaTien.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TongGiaTien.ForeColor = Color.Black;
            lb_TongGiaTien.Location = new Point(683, 609);
            lb_TongGiaTien.Name = "lb_TongGiaTien";
            lb_TongGiaTien.RightToLeft = RightToLeft.Yes;
            lb_TongGiaTien.Size = new Size(37, 45);
            lb_TongGiaTien.TabIndex = 55;
            lb_TongGiaTien.Text = "0";
            lb_TongGiaTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 188, 18);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(26, 609);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(883, 45);
            textBox1.TabIndex = 53;
            textBox1.Text = "Tổng giá tiền:";
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.FromArgb(255, 138, 0);
            btn_ThanhToan.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThanhToan.Location = new Point(749, 660);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(161, 50);
            btn_ThanhToan.TabIndex = 52;
            btn_ThanhToan.Text = "Thanh Toán";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 14);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 51;
            label3.Text = "Yêu Cầu Dịch Vụ";
            // 
            // dtg_ChonDV
            // 
            dtg_ChonDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_ChonDV.BackgroundColor = Color.White;
            dtg_ChonDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_ChonDV.Location = new Point(19, 389);
            dtg_ChonDV.Name = "dtg_ChonDV";
            dtg_ChonDV.RowHeadersWidth = 51;
            dtg_ChonDV.RowTemplate.Height = 29;
            dtg_ChonDV.Size = new Size(890, 200);
            dtg_ChonDV.TabIndex = 0;
            dtg_ChonDV.CellValueChanged += dtg_ChonDV_CellValueChanged;
            // 
            // dtg_HienThiDSDV
            // 
            dtg_HienThiDSDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_HienThiDSDV.BackgroundColor = Color.White;
            dtg_HienThiDSDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HienThiDSDV.Location = new Point(20, 67);
            dtg_HienThiDSDV.Name = "dtg_HienThiDSDV";
            dtg_HienThiDSDV.RowHeadersWidth = 51;
            dtg_HienThiDSDV.RowTemplate.Height = 29;
            dtg_HienThiDSDV.Size = new Size(889, 306);
            dtg_HienThiDSDV.TabIndex = 0;
            dtg_HienThiDSDV.CellClick += dtg_HienThiDSDV_CellClick;
            // 
            // YeuCauDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(937, 714);
            Controls.Add(panel_YeuCauDichVu);
            Name = "YeuCauDichVu";
            Text = "YeuCauDichVu";
            Load += YeuCauDichVu_Load;
            panel_YeuCauDichVu.ResumeLayout(false);
            panel_YeuCauDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_ChonDV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_HienThiDSDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_YeuCauDichVu;
        private TextBox textBox1;
        private Button btn_ThanhToan;
        private Label label3;
        private DataGridView dtg_ChonDV;
        private DataGridView dtg_HienThiDSDV;
        private Label lb_TongGiaTien;
    }
}