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
    public partial class HoaDon : Form
    {

        private Control[] controls;

        public Panel PNchinh()
        {
            return panel2;
        }

        #region lấy đối tượng các form
        Vouchers vc = new Vouchers()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        TaoVe tv = new TaoVe()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        KhachHang KH = new KhachHang()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        LichChieu Lc = new LichChieu()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        TheThanhVien Thetv = new TheThanhVien()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        DichVu DV = new DichVu()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        YeuCauDichVu Ycdv = new YeuCauDichVu()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        ThongKe TK = new ThongKe()
        {
            Dock = DockStyle.Fill,
            TopLevel = false,
            TopMost = true,
            FormBorderStyle = FormBorderStyle.None
        };
        #endregion

        public HoaDon()
        {
            InitializeComponent();
            controls = panel2.Controls.Cast<Control>().ToArray();
        }

        #region các sự kiện click
        private void Panel_Phim_Click(object sender, EventArgs e)
        {
            Phim ph = new Phim();
            Panel panel = ph.phim();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void panel_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login f1 = new Login();
                f1.ShowDialog();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void Panel_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKe TK = new ThongKe();
            Panel panel = TK.thongKe();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_YeucauDichVu_Click(object sender, EventArgs e)
        {
            YeuCauDichVu Ycdv = new YeuCauDichVu();
            Panel panel = Ycdv.yeuCauDichVu();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_DichVu_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            Panel panel = dv.dichVu();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_TheThanhVien_Click(object sender, EventArgs e)
        {
            TheThanhVien Thetv = new TheThanhVien();
            Panel panel = Thetv.theTV();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_LichChieu_Click(object sender, EventArgs e)
        {
            LichChieu lc = new LichChieu();
            Panel panel = lc.lichChieu();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_KhachHang_Click(object sender, EventArgs e)
        {
            KhachHang Kh = new KhachHang();
            Panel panel = Kh.khachHang();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_TaoVe_Click(object sender, EventArgs e)
        {
            TaoVe tv = new TaoVe();
            Panel panel = tv.taoVe();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }

        private void Panel_TaoHoaDon_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.AddRange(controls);
        }

        private void Panel_Voucher_Click(object sender, EventArgs e)
        {
            Vouchers vc = new Vouchers();
            Panel panel = vc.Voucher();
            panel2.Controls.Clear();
            panel2.Controls.Add(panel);
        }
        #endregion

        #region các sự kiện load

        private void HoaDon_Load(object sender, EventArgs e)
        {
            panel2.Controls.Add(vc);
            panel2.Controls.Add(tv);
            panel2.Controls.Add(KH);
            panel2.Controls.Add(Lc);
            panel2.Controls.Add(Thetv);
            panel2.Controls.Add(DV);
            panel2.Controls.Add(Ycdv);
            panel2.Controls.Add(TK);
        }
        #endregion

        #region các sự kiện mouse down
        private void panel_DangXuat_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.FromArgb(190, 0, 0);
        }

        private void Panel_ThongKe_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.FromArgb(190, 0, 0);
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_YeucauDichVu_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.FromArgb(190, 0, 0);
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_TaoVe_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.FromArgb(190, 0, 0);
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_TaoHoaDon_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.FromArgb(190, 0, 0);
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_Voucher_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.FromArgb(190, 0, 0);
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_TheThanhVien_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.FromArgb(190, 0, 0);
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_DichVu_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.FromArgb(190, 0, 0);
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_KhachHang_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_Phim.BackColor = Color.Orange;
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.FromArgb(190, 0, 0);
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;

        }

        private void Panel_Phim_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_Phim.BackColor = Color.FromArgb(190, 0, 0);
            Panel_LichChieu.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }

        private void Panel_LichChieu_MouseDown(object sender, MouseEventArgs e)
        {
            Panel_LichChieu.BackColor = Color.FromArgb(190, 0, 0);
            Panel_Phim.BackColor = Color.Orange;
            Panel_KhachHang.BackColor = Color.Orange;
            Panel_TaoVe.BackColor = Color.Orange;
            Panel_TaoHoaDon.BackColor = Color.Orange;
            Panel_Voucher.BackColor = Color.Orange;
            Panel_TheThanhVien.BackColor = Color.Orange;
            Panel_DichVu.BackColor = Color.Orange;
            Panel_YeucauDichVu.BackColor = Color.Orange;
            Panel_ThongKe.BackColor = Color.Orange;
            panel_DangXuat.BackColor = Color.Orange;
        }
        #endregion


        //
    }
}
