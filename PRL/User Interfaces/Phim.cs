using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.User_Interfaces
{
    public partial class Phim : Form
    {
        PhimServices psv = new PhimServices();
        public Phim()
        {
            InitializeComponent();

            // Đặt giá trị lớn nhất của thanh trượt là chiều cao của Panel
            VSBphim.Maximum = Panel_Phim.Height;
            LoadPhim();
        }


        private void VSBphim_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = VSBphim.Value;

            Panel_Phim.Top = -scrollValue;


        }

        private void Panel_Phim_SizeChanged(object sender, EventArgs e)
        {
            VSBphim.Maximum = Panel_Phim.Height;
        }
        public Panel phim()
        {
            return Panel_Scroll;
        }

        public void LoadPhim()
        {
            foreach (var item in psv.GetAllPhim())
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = "";
                groupBox.AutoSize = true;
                groupBox.Margin = new Padding(5, 5, 10, 10);


                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(200,300);
                pictureBox.Image = Image.FromFile(@"C:\Users\TIEN GIAP\Source\Repos\DuAn1_New_Gr_6H50\PRL\Resources\anhphim.png");
                pictureBox.Location = new Point(10, 20);

                Font customFont = new Font("Arial", 12, FontStyle.Bold);

                Label label1 = new Label();
                label1.Location = new Point(15, pictureBox.Bottom + 10);
                label1.Font = customFont;
                label1.ForeColor = Color.White;

                Label label2 = new Label();
                label2.Location = new Point(15, label1.Bottom + 10);

                string tenphim = item.TenPhim.ToString();
                string thoiluong = item.ThoiLuong.ToString() + " phút";

                label1.Text = tenphim;
                label2.Text = thoiluong;

                groupBox.Controls.Add(pictureBox);
                groupBox.Controls.Add(label1);
                groupBox.Controls.Add(label2);

                FLPanel_DSphim.Controls.Add(groupBox);
                
            }
        }

        
    }
}
