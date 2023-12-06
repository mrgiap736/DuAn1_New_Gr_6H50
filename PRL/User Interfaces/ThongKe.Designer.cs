namespace PRL.User_Interfaces
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel_Thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel_Thongke
            // 
            panel_Thongke.Controls.Add(textBox2);
            panel_Thongke.Controls.Add(textBox1);
            panel_Thongke.Controls.Add(button1);
            panel_Thongke.Controls.Add(label3);
            panel_Thongke.Controls.Add(dataGridView1);
            panel_Thongke.Location = new Point(2, 1);
            panel_Thongke.Name = "panel_Thongke";
            panel_Thongke.Size = new Size(923, 940);
            panel_Thongke.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 188, 18);
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(9, 641);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(883, 46);
            textBox2.TabIndex = 54;
            textBox2.Text = "Doanh Thu Ngày:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 188, 18);
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(9, 576);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(883, 46);
            textBox1.TabIndex = 54;
            textBox1.Text = "Số lượng vé bán trong ngày :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(112, 88, 61);
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(733, 84);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 50;
            button1.Text = "Biểu đồ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(491, 32);
            label3.TabIndex = 49;
            label3.Text = "Doanh Thu Trong Ngày Và  Số Lượng Vé Bán";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(917, 418);
            dataGridView1.TabIndex = 0;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(931, 714);
            Controls.Add(panel_Thongke);
            Name = "ThongKe";
            Text = "ThongKe";
            panel_Thongke.ResumeLayout(false);
            panel_Thongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Thongke;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private DataGridView dataGridView1;
    }
}