using BUS.Services;
using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.User_Interfaces
{
    public partial class TaoVe : Form
    {
        TaoVeServices tvsv = new TaoVeServices();
        public string maghe { get; set; }
        public string maphim { get; set; }
        public TaoVe(string maghe, string maphim)
        {
            InitializeComponent();
            this.maghe = maghe;
            this.maphim = maphim;
            cbo_GiaVe.SelectedIndex = 0;
            LoadVe();
        }
        public TaoVe()
        {

        }
        public Panel taoVe()
        {
            return Panel_taoVe;
        }

        private void TaoVe_Load(object sender, EventArgs e)
        {

        }

        public void LoadVe()
        {
            dtg_HienThiDSVe.Rows.Clear();

            var lc = tvsv.GetLC(maphim);
            if(lc == null)
            {
                MessageBox.Show("Phim này hiện chưa có lịch chiếu !");
                Phim ph = new Phim();
                Panel panel = ph.phim();
                Panel_taoVe.Controls.Clear();
                Panel_taoVe.Controls.Add(panel);
                return;
            } 
            else
            {
                

                txt_MaPhim.Text = maphim;
                txt_Lich.Text = lc.MaLichChieu.ToString();
                txt_MaPhong.Text = "1";

                dtg_HienThiDSVe.ColumnCount = 5;

                dtg_HienThiDSVe.Columns[0].Name = "mave";
                dtg_HienThiDSVe.Columns[0].HeaderText = "Mã vé";

                dtg_HienThiDSVe.Columns[1].Name = "maphim";
                dtg_HienThiDSVe.Columns[1].HeaderText = "Mã phim";

                dtg_HienThiDSVe.Columns[2].Name = "maphong";
                dtg_HienThiDSVe.Columns[2].HeaderText = "Mã phòng";

                dtg_HienThiDSVe.Columns[3].Name = "maghe";
                dtg_HienThiDSVe.Columns[3].HeaderText = "Mã ghế";

                dtg_HienThiDSVe.Columns[4].Name = "malich";
                dtg_HienThiDSVe.Columns[4].HeaderText = "Mã lịch";

                foreach (var item in tvsv.GetAllVe())
                {
                    dtg_HienThiDSVe.Rows.Add(item.MaVe, item.MaPhim, item.MaPhongChieu, item.MaGhe, item.MaLichChieuNavigation.ThoiGianChieu);
                }
            }           
        }

        private void btn_TaoVe_Click(object sender, EventArgs e)
        {
            try
            {
                Ve ve = new Ve();
                
                ve.MaVe = txt_Mave.Text;
                ve.MaGhe = maghe;
                ve.MaLichChieu = txt_Lich.Text;
                ve.MaPhim = maphim;
                ve.MaPhongChieu = 1;

                tvsv.TaoVeMoi(ve);
                LoadVe();
                MessageBox.Show("Tạo vé thành công ! Thanh toán 70k cho nhân viên.");
                //cập nhật trạng thái ghế
                DBContext db = new DBContext();
                Ghe ghe = db.Ghes.Find(maghe);
                ghe.TrangThai = "Hết";
                db.Ghes.Update(ghe);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi rồi");
                return;
            }
            
        }
    }
}
