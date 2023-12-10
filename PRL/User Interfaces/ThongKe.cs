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
    public partial class ThongKe : Form
    {

        //ThongKeSV HienThongKe = new ThongKeSV();
        public ThongKe()
        {
            InitializeComponent();
            LoadThongKe();
        }

        public Panel thongKe()
        {
            return panel_Thongke;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }
        public void LoadThongKe()
        {
            dgvThongKe.DataSource = ThongKeSV.GetAllTK();
            //dgvThongKe.Columns[0].HeaderText = "Mã Thống Kê";
            //dgvThongKe.Columns[1].HeaderText = "Doanh Thu Phim Ngày";
            //dgvThongKe.Columns[2].HeaderText = "Doanh Thu DV Ngày";
            //dgvThongKe.Columns[3].HeaderText = "Số Vé Đã Bán";

            //foreach (var item in ThongKeSV.GetAllDV())
            //{
            //    dgvThongKe.Rows.Add(item.MaThongKe, item.DoanhThuPhimNgay.ToString(), item.DoanhThuDichVuNgay.ToString(), item.SoVeDaBan.ToString());
            //}
        }

        private void dgvThongKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtDoanhThuDichVuNgay.Text = dgvThongKe.Rows[d].Cells[2].Value.ToString();
            txtDoanhThuPhim.Text = dgvThongKe.Rows[d].Cells[1].Value.ToString();
            txtSoVeBan.Text = dgvThongKe.Rows[d].Cells[3].Value.ToString();
        }
    }
}
