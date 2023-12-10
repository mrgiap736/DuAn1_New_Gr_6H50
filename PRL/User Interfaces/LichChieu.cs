using BUS.Services;
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
    public partial class LichChieu : Form
    {
        LichChieuServices lcsv = new LichChieuServices();
        public LichChieu()
        {
            InitializeComponent();

            LoadLichChieu();
            LoadCboPhim();
            LoadCboPhong();
        }
        public Panel lichChieu()
        {
            return Panel_lichChieu;
        }

        private string malc;
        private string maphim;
        public void LoadLichChieu()
        {
            dtg_HienThiLichChieu.Rows.Clear();

            //
            dtg_HienThiLichChieu.ColumnCount = 6;

            dtg_HienThiLichChieu.Columns[0].Name = "stt";
            dtg_HienThiLichChieu.Columns[0].HeaderText = "STT";

            dtg_HienThiLichChieu.Columns[1].Name = "phim";
            dtg_HienThiLichChieu.Columns[1].HeaderText = "Phim";

            dtg_HienThiLichChieu.Columns[2].Name = "ngay";
            dtg_HienThiLichChieu.Columns[2].HeaderText = "Thời gian chiếu";
            dtg_HienThiLichChieu.Columns[2].Width = 300;

            dtg_HienThiLichChieu.Columns[3].Name = "phong";
            dtg_HienThiLichChieu.Columns[3].HeaderText = "Phòng";

            dtg_HienThiLichChieu.Columns[4].Name = "malc";
            dtg_HienThiLichChieu.Columns[4].Visible = false;

            dtg_HienThiLichChieu.Columns[5].Name = "maphim";
            dtg_HienThiLichChieu.Columns[5].Visible = false;


            int stt = 1;
            foreach (var item in lcsv.GetAllLichChieu())
            {
                dtg_HienThiLichChieu.Rows.Add(stt++, item.MaPhimNavigation.TenPhim, item.ThoiGianChieu, item.MaPhongChieu, item.MaLichChieu, item.MaPhim);
            }
        }

        public void LoadCboPhim()
        {
            cbo_maphim.DataSource = lcsv.GetNamePhim();
        }

        public void LoadCboPhong()
        {
            cbo_phongchieu.DataSource = lcsv.GetMaPhong();
        }

        private void dtg_HienThiLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                malc = dtg_HienThiLichChieu.Rows[rowIndex].Cells[4].Value.ToString();
                maphim = dtg_HienThiLichChieu.Rows[rowIndex].Cells[5].Value.ToString();

                txt_malc.Text = dtg_HienThiLichChieu.Rows[rowIndex].Cells[4].Value.ToString();
                DateTime tgchieu = Convert.ToDateTime(dtg_HienThiLichChieu.Rows[rowIndex].Cells[2].Value);

                cbo_maphim.Text = dtg_HienThiLichChieu.Rows[rowIndex].Cells[5].Value.ToString();
                txt_ngaychieu.Text = tgchieu.ToShortDateString();
                txt_giochieu.Text = tgchieu.ToShortTimeString();
                cbo_phongchieu.Text = dtg_HienThiLichChieu.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }

        public bool CheckPhong()
        {
            bool check = true;

            // Chuyển đổi giá trị từ ComboBox sang số nguyên
            int selectedPhongChieu;
            if (!int.TryParse(cbo_phongchieu.SelectedItem?.ToString(), out selectedPhongChieu))
            {
                // Xử lý khi không chuyển đổi được
                return check;
            }

            foreach (DataGridViewRow item in dtg_HienThiLichChieu.Rows)
            {
                // So sánh giá trị trong ô cột với giá trị đã chọn từ ComboBox
                if (item.Cells[3].Value != null &&
                    selectedPhongChieu == Convert.ToInt32(item.Cells[3].Value))
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        private void btn_TaoLich_Click(object sender, EventArgs e)
        {
            if (!CheckPhong())
            {
                DialogResult result = MessageBox.Show("Phòng này đã có lịch vui lòng chọn phòng khác !", "Thông báo");
                return;
            }
            else
            {
                DAL.DomainClass.LichChieu lc = new DAL.DomainClass.LichChieu();

                lc.MaLichChieu = txt_malc.Text;
                lc.MaPhim = cbo_maphim.Text;
                lc.MaPhongChieu = Convert.ToInt32(cbo_phongchieu.Text);

                //thoi gian chieu
                string thoigian = txt_ngaychieu.Text + " " + txt_giochieu.Text;
                lc.ThoiGianChieu = Convert.ToDateTime(thoigian);

                lcsv.CreateLichChieu(lc);

                LoadLichChieu();
            }

        }

        private void btn_xoalich_Click(object sender, EventArgs e)
        {
            lcsv.DeleteLichChieu(malc);
            LoadLichChieu();
        }

        private void btn_UpdateTT_Click(object sender, EventArgs e)
        {
            LoadLichChieu();
        }

        private void btn_SuaLich_Click(object sender, EventArgs e)
        {
            string maphim = cbo_maphim.SelectedItem.ToString();
            string tg = txt_ngaychieu.Text + " " + txt_giochieu.Text;
            DateTime thoigianchieu = Convert.ToDateTime(tg);
            int maphongchieu = Convert.ToInt32(cbo_phongchieu.SelectedItem);

            lcsv.UpdateLichChieu(malc, maphim, maphongchieu, thoigianchieu);

            LoadLichChieu();
        }
    }
}
