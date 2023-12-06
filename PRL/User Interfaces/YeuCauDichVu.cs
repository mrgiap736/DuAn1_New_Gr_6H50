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

namespace PRL.User_Interfaces
{
    public partial class YeuCauDichVu : Form
    {

        YCDichVuSV svces = new YCDichVuSV();
        public YeuCauDichVu()
        {
            InitializeComponent();
            LoadDataHienThiDSDV();
            LoadColumnsChonDV();
        }
        public Panel yeuCauDichVu()
        {
            return panel_YeuCauDichVu;
        }

        public void LoadDataHienThiDSDV()
        {

            dtg_HienThiDSDV.ColumnCount = 3;

            dtg_HienThiDSDV.Columns[0].Name = "madv";
            dtg_HienThiDSDV.Columns[0].HeaderText = "Mã DV";

            dtg_HienThiDSDV.Columns[1].Name = "mota";
            dtg_HienThiDSDV.Columns[1].HeaderText = "Tên dịch vụ";

            dtg_HienThiDSDV.Columns[2].Name = "giadv";
            dtg_HienThiDSDV.Columns[2].HeaderText = "Giá dịch vụ";


            foreach (var item in svces.GetAllDV())
            {
                dtg_HienThiDSDV.Rows.Add(item.MaDichVu, item.TenDichVu, item.GiaDichVu.ToString());
            }
        }


        public void LoadColumnsChonDV()
        {
            dtg_ChonDV.ColumnCount = 3;

            dtg_ChonDV.Columns[0].Name = "dvdachon";
            dtg_ChonDV.Columns[0].HeaderText = "Dịch vụ đã chọn";
            dtg_ChonDV.Columns[0].ReadOnly = false;

            dtg_ChonDV.Columns[1].Name = "soluong";
            dtg_ChonDV.Columns[1].HeaderText = "Số lượng";
            dtg_ChonDV.Columns[1].Width = 50;
            dtg_ChonDV.Columns[0].ReadOnly = true;

            dtg_ChonDV.Columns[2].Name = "giadv";
            dtg_ChonDV.Columns[2].HeaderText = "Giá dịch vụ";
            dtg_ChonDV.Columns[0].ReadOnly = false;
        }


        int giatien = 0;
        private void dtg_HienThiDSDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex == -1)
            {
                return;
            }
            else
            {

                string selectedServiceName = dtg_HienThiDSDV.Rows[rowIndex].Cells[1].Value?.ToString();


                if (!string.IsNullOrEmpty(selectedServiceName))
                {
                    // Tạo biến kiểm tra xem dịch vụ đã có trong danh sách chọn chưa
                    bool existsInChonDV = false;

                    int soluong = 1;

                    foreach (DataGridViewRow item in dtg_ChonDV.Rows)
                    {
                        //lấy tên check
                        string cellValue = item.Cells[0].Value?.ToString();
                        //lấy đơn giá
                        int cellValueGia = Convert.ToInt32(item.Cells[2].Value?.ToString());

                        // Nếu đã tồn tại, tăng số lượng lên 1 giá trị
                        if (selectedServiceName.Equals(cellValue))
                        {
                            soluong = Convert.ToInt32(item.Cells[1].Value) + 1;
                            giatien = Convert.ToInt32(dtg_HienThiDSDV.Rows[rowIndex].Cells[2].Value);

                            item.Cells[1].Value = soluong;
                            item.Cells[2].Value = giatien * soluong;

                            //đổi giá theo số lượng                

                            existsInChonDV = true;
                            break;
                        }
                    }

                    // Nếu chưa tồn tại, thêm mới vào danh sách chọn
                    if (!existsInChonDV)
                    {
                        giatien = Convert.ToInt32(dtg_HienThiDSDV.Rows[rowIndex].Cells[2].Value);
                        dtg_ChonDV.Rows.Add(selectedServiceName, soluong, giatien);
                        LoadColumnsChonDV();
                    }
                }
            }

            int tongGia = 0;
            foreach (DataGridViewRow item in dtg_ChonDV.Rows)
            {
                int selectGia = Convert.ToInt32(item.Cells[2].Value);
                tongGia = tongGia + selectGia;
            }

            lb_TongGiaTien.Text = tongGia.ToString();
        }

        int giaBan;
        private void dtg_ChonDV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            // Kiểm tra xem sự kiện có xảy ra trong cột số lượng không
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Lấy giá trị số lượng mới từ ô đã thay đổi
                int newSoLuong;
                if (int.TryParse(dtg_ChonDV.Rows[e.RowIndex].Cells["soluong"].Value.ToString(), out newSoLuong))
                {
                    // Thực hiện công thức tính giá mới dựa trên số lượng
                    giaBan = newSoLuong * giatien;

                    // Cập nhật giá mới vào ô Giá
                    dtg_ChonDV.Rows[e.RowIndex].Cells["giadv"].Value = giaBan;
                    lb_TongGiaTien.Text = giaBan.ToString();
                }
            }
            else return;

            // Kiểm tra xem sự kiện có xảy ra trong cột số lượng không
            //if (e.ColumnIndex >=0 && e.RowIndex >= 0)
            //{
            //    // Lấy giá trị số lượng mới từ ô đã thay đổi
            //    int newSoLuong;
            //    if (int.TryParse(dtg_ChonDV.Rows[e.RowIndex].Cells["soluong"].Value.ToString(), out newSoLuong))
            //    {
            //        // Thực hiện công thức tính giá mới dựa trên số lượng
            //        giaBan = newSoLuong * giatien;

            //        // Cập nhật giá mới vào ô Giá
            //        dtg_ChonDV.Rows[e.RowIndex].Cells["giadv"].Value = giaBan;
            //    }
            //}

            //// Tính tổng giá tiền sau mỗi thay đổi
            //int tongGia = 0;
            //foreach (DataGridViewRow item in dtg_ChonDV.Rows)
            //{
            //    int selectGia = Convert.ToInt32(item.Cells["giadv"].Value);
            //    tongGia += selectGia;
            //}

            //// Hiển thị tổng giá tiền
            //lb_TongGiaTien.Text = tongGia.ToString();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tổng bill: {lb_TongGiaTien.Text   }");

            dtg_ChonDV.Rows.Clear();
        }
    }
}
