using BUS.Services;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class DichVu : Form
    {
        Regex NumbersOnly = new Regex(@"\d+$");
        Regex ASCIIOnly = new Regex(@"[A-Za-z0-9]+$");
        public DichVu()
        {
            InitializeComponent();
            BTN_Update.Enabled = false;
            BTN_Delete.Enabled = false;
            GetServiceList();
        }
        public Panel dichVu()
        {
            return panel_DichVu;
        }

        private void BTN_CreateSvc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_ServiceID.Text) ||
                string.IsNullOrWhiteSpace(Txt_SvcName.Text) ||
                string.IsNullOrWhiteSpace(Txt_SvcPrice.Text) ||
                string.IsNullOrWhiteSpace(Txt_Details.Text))
            {
                MessageBox.Show("Thiếu thông tin", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ASCIIOnly.IsMatch(Txt_ServiceID.Text))
            {
                MessageBox.Show("Chỉ được điền các ký tự không dấu vào trường mã DV!!!\nCác ký tự dùng được: A-Z, a-z, 0-9", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!NumbersOnly.IsMatch(Txt_SvcPrice.Text))
            {
                MessageBox.Show("Chỉ được điền số vào trường giá tiền", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var DichVuMoi = new DAL.DomainClass.DichVu();
            DichVuMoi.MaDichVu = Txt_ServiceID.Text;
            DichVuMoi.TenDichVu = Txt_SvcName.Text;
            DichVuMoi.GiaDichVu = int.Parse(Txt_SvcPrice.Text);
            DichVuMoi.TrangThaiDichVu = Txt_Details.Text;
            Svc_DichVu.Them_Moi(DichVuMoi);
            MessageBox.Show("Thêm thành công", "DONEZO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetServiceList();
            ResetAll();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_ServiceID.Text) ||
                string.IsNullOrWhiteSpace(Txt_SvcName.Text) ||
                string.IsNullOrWhiteSpace(Txt_SvcPrice.Text) ||
                string.IsNullOrWhiteSpace(Txt_Details.Text))
            {
                MessageBox.Show("Thiếu thông tin", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var DichVuCapNhat = new DAL.DomainClass.DichVu();
            DichVuCapNhat.MaDichVu = Txt_ServiceID.Text;
            DichVuCapNhat.TenDichVu = Txt_SvcName.Text;
            DichVuCapNhat.GiaDichVu = int.Parse(Txt_SvcPrice.Text);
            DichVuCapNhat.TrangThaiDichVu = Txt_Details.Text;
            Svc_DichVu.Cap_Nhat(DichVuCapNhat);
            MessageBox.Show("Cập nhật thành công", "DONEZO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetServiceList();
            ResetAll();
        }
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            var DichVuXoa = new DAL.DomainClass.DichVu();
            DichVuXoa.MaDichVu = Txt_ServiceID.Text;
            DichVuXoa.TenDichVu = Txt_SvcName.Text;
            DichVuXoa.GiaDichVu = int.Parse(Txt_SvcPrice.Text);
            DichVuXoa.TrangThaiDichVu = Txt_Details.Text;
            DialogResult Confirmation = MessageBox.Show("Do you want to delete????", "O H YEA  DELET TIEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Confirmation == DialogResult.Yes)
            {
                if (Txt_ServiceID.Text == DichVuXoa.MaDichVu &&
                    Txt_SvcName.Text == DichVuXoa.TenDichVu &&
                    int.Parse(Txt_SvcPrice.Text) == DichVuXoa.GiaDichVu &&
                    Txt_Details.Text == DichVuXoa.TrangThaiDichVu)
                {
                    Svc_DichVu.Xoa(DichVuXoa);
                    MessageBox.Show("Dữ liệu go bye bye", "DONEZO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetServiceList();
                    ResetAll();
                }
                else
                {
                    MessageBox.Show("Dữ liệu không đồng nhất với nhau! Hãy thử lại.", "???????", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetAll();
                }
            }
        }

        private void Screen_Svc_CellClick(object sender, DataGridViewCellEventArgs Event)
        {
            BTN_CreateSvc.Enabled = false;
            BTN_Update.Enabled = true;
            BTN_Delete.Enabled = true;
            try
            {
                Txt_ServiceID.Text = Screen_Svc.Rows[Event.RowIndex].Cells[0].Value.ToString();
                Txt_SvcName.Text = Screen_Svc.Rows[Event.RowIndex].Cells[1].Value.ToString();
                Txt_SvcPrice.Text = Screen_Svc.Rows[Event.RowIndex].Cells[2].Value.ToString();
                Txt_Details.Text = Screen_Svc.Rows[Event.RowIndex].Cells[3].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                ResetAll();
                return;
            }
        }

        private void GetServiceList()
        {
            Screen_Svc.DataSource = Svc_DichVu.TaiDuLieu();
            Screen_Svc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Screen_Svc.Columns[0].HeaderText = "Mã dịch vụ";
            Screen_Svc.Columns[1].HeaderText = "Mô tả dịch vụ";
            Screen_Svc.Columns[2].HeaderText = "Giá";
            Screen_Svc.Columns[3].HeaderText = "Trạng thái";
            Screen_Svc.Columns[4].Visible = false;
        }

        private void ResetAll()
        {
            Txt_ServiceID.Text = string.Empty;
            Txt_SvcName.Text = string.Empty;
            Txt_SvcPrice.Text = string.Empty;
            Txt_Details.Text = string.Empty;
            BTN_CreateSvc.Enabled = true;
            BTN_Update.Enabled = false;
            BTN_Delete.Enabled = false;
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
    }
}
