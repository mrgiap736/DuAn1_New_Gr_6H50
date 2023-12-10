using BUS.Services;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.User_Interfaces
{
    public partial class ChonGhe : Form
    {
        PhimServices psv = new PhimServices();
        public DAL.DomainClass.Phim phimif { get; set; }

        //
        string maghe; //lấy mã ghế để tạo vé
        bool checkChonGhe = false;
        //
        public ChonGhe(DAL.DomainClass.Phim phimif)
        {
            this.phimif = phimif;
            InitializeComponent();
            LoadPhimDaChon();
            Colorbutton();
            LoadGhe();
        }



        public Panel chonghe()
        {
            return Pn_ChonGhe;
        }

        public void LoadPhimDaChon()
        {
            if (phimif != null)
            {

                // PictureBox
                PictureBox ptb = new PictureBox();
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                //ptb.Image = Image.FromFile("path_to_your_image.jpg"); // Replace with the path to your image
                Pn_HienThiPhim.Controls.Add(ptb);
                Pn_HienThiPhim.AutoSize = true;

                // Labels

                Font customFont = new Font("Arial", 15, FontStyle.Bold);
                Font customFont2 = new Font("Arial", 11, FontStyle.Bold);


                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Font = customFont;
                label1.ForeColor = Color.White;
                label1.Text = "Phim: " + phimif.TenPhim;

                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Font = customFont2;
                label2.ForeColor = Color.White;
                label2.Text = "Xuất chiếu: " + phimif.NgayPhatHanh.ToString();

                Label label3 = new Label();
                label3.AutoSize = true;
                label3.Font = customFont2;
                label3.ForeColor = Color.White;
                label3.Text = "Thời lượng: " + phimif.ThoiLuong.ToString();

                Label label6 = new Label();
                label6.AutoSize = true;
                label6.Font = customFont2;
                label6.ForeColor = Color.White;
                label6.Text = "Thể loại: " + phimif.MaTheLoaiNavigation.TenTheLoai.ToString();

                Label label4 = new Label();
                label4.AutoSize = true;
                label4.Font = customFont2;
                label4.ForeColor = Color.White;
                label4.Text = "Đánh giá: " + phimif.Rated;

                Label label5 = new Label();
                label5.AutoSize = true;
                label5.Font = customFont2;
                label5.ForeColor = Color.White;
                label5.Text = "Rạp: 1";

                // Add Labels to TableLayoutPanel
                table_LPanel.Controls.Add(label1);
                table_LPanel.Controls.Add(label2);
                table_LPanel.Controls.Add(label3);
                table_LPanel.Controls.Add(label6);
                table_LPanel.Controls.Add(label4);
                table_LPanel.Controls.Add(label5);
                table_LPanel.Padding = new Padding(5, 12, 5, 5);
            }
            else
            {
                MessageBox.Show("Phim bị null");
            }

        }

        public void Colorbutton()
        {
            foreach (Control item in Pn_GhevaManHinh.Controls)
            {
                if (item is Button)
                {
                    item.ForeColor = Color.White;
                    Button button = (Button)item;
                    button.FlatAppearance.BorderSize = 0;
                }
            }
        }

        //
        private Button selectedSeat = null;
        private Dictionary<Button, Color> originalColors = new Dictionary<Button, Color>();

        public void LoadGhe()
        {
            List<Ghe> listg = psv.GetAllGhe();
            // Đảm bảo số lượng button trong panel và số lượng ghế từ database là giống nhau
            if (listg.Count == Pn_DSGhe.Controls.Count)
            {
                for (int i = 0; i < listg.Count; i++)
                {
                    Button button = (Button)Pn_DSGhe.Controls[i];
                    Ghe seat = listg[i];

                    button.Text = seat.MaGhe.ToString();
                    button.Name = $"btnSeat_{seat.MaGhe}"; // Mã hóa tên button để có thể xác định ghế tương ứng
                    button.ForeColor = Color.White;
                    if (seat.TrangThai.Equals("Hết"))
                    {
                        button.BackColor = Color.FromArgb(152, 37, 29);
                        button.Enabled = false;
                    }

                    //button.Click += SeatButton_Click; // Đặt sự kiện click cho button
                    button.MouseClick += SeatButton_MouserDown;
                    // Lưu màu ban đầu của button
                    originalColors[button] = button.BackColor;
                }
            }
        }

      
        private void SeatButton_MouserDown(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (selectedSeat != null)
            {
                // Đặt lại màu cho ghế trước đó
                selectedSeat.BackColor = originalColors[selectedSeat];
            }

            // Đổi màu của ghế được chọn
            clickedButton.BackColor = Color.DodgerBlue;

            // Lưu lại ghế được chọn
            selectedSeat = clickedButton;

            maghe = clickedButton.Text;
            checkChonGhe = true;
        }

        private void btn_DatVe_Click(object sender, EventArgs e)
        {
            if(checkChonGhe)
            {
                TaoVe tv = new TaoVe(maghe, phimif.MaPhim);

                Panel pn = tv.taoVe();

                Pn_ChonGhe.Controls.Clear();
                Pn_ChonGhe.Controls.Add(pn);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn ghế !");
                return;
            }    
            
        }
    }
}
