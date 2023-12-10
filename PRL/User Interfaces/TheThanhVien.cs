using BUS.Services;
using Microsoft.Extensions.Logging;
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
    public partial class TheThanhVien : Form
    {
        Regex NumbersOnly = new Regex(@"[0-9]*$");
        Regex ASCIIOnly = new Regex(@"[A-Za-z0-9]+$");
        Regex DateTime_Filter = new Regex(@"^(\d{0,2}[/]?\d{1,2})?[/]?\d{1,6}$"); // (dd/mm/yyyy(y))
        Regex DateTime_Checker = new Regex(@"^\d{1,2}/\d{1,2}/\d{4,5}");
        public TheThanhVien()
        {
            InitializeComponent();
            BTN_Update.Enabled = false;
            BTN_Delete.Enabled = false;
            GetServiceList();
        }
        public Panel theTV()
        {
            return Panel_TheTv;
        }

        private void BTN_CreateNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Phone.Text) ||
                string.IsNullOrWhiteSpace(Combo_Tier.Text) ||
                string.IsNullOrWhiteSpace(Txt_Available.Text) ||
                string.IsNullOrWhiteSpace(Txt_DieDate.Text) ||
                string.IsNullOrWhiteSpace(Txt_Points.Text)
               )
            {
                MessageBox.Show("Thiếu thông tin", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!NumbersOnly.IsMatch(Txt_Phone.Text) || !NumbersOnly.IsMatch(Txt_Points.Text))
            {
                MessageBox.Show("Chỉ được điền số vào trường SĐT và điểm", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var TTVMoi = new DAL.DomainClass.TheThanhVien();
            TTVMoi.SdtkhachHang = Txt_Phone.Text;
            TTVMoi.LoaiThanhVien = Combo_Tier.Text;
            TTVMoi.NgayHieuLuc = DateTime.Parse(Txt_Available.Text);
            TTVMoi.NgayHetHan = DateTime.Parse(Txt_DieDate.Text);
            TTVMoi.DiemThanhVien = int.Parse(Txt_Points.Text);
            try
            {
                Svc_TheThanhVien.Them_Moi(TTVMoi);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException)
            {
                MessageBox.Show($"Không tạo được thẻ KH, không thể tìm thấy SĐT {Txt_Phone.Text}!", "...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thêm thành công", "DONEZO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetServiceList();
            ResetAll();
        }

        private void GetServiceList()
        {
            Screen_MemberCard.DataSource = Svc_TheThanhVien.Tai_Du_Lieu();
            Screen_MemberCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Screen_MemberCard.Columns[0].HeaderText = "SĐT";
            Screen_MemberCard.Columns[1].HeaderText = "Điểm";
            Screen_MemberCard.Columns[2].HeaderText = "Loại thành viên";
            Screen_MemberCard.Columns[3].HeaderText = "Ngày hiệu lực";
            Screen_MemberCard.Columns[4].HeaderText = "Ngày hết hạn";
            Screen_MemberCard.Columns[5].Visible = false;
        }

        private void ResetAll()
        {
            Txt_Phone.Text = string.Empty;
            Combo_Tier.Text = string.Empty;
            Txt_Available.Text = string.Empty;
            Txt_DieDate.Text = string.Empty;
            Txt_Points.Text = string.Empty;

            BTN_CreateNew.Enabled = true;
            BTN_Update.Enabled = false;
            BTN_Delete.Enabled = false;
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void Txt_Available_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!DateTime_Filter.IsMatch(Txt_Available.Text.Insert(Txt_Available.SelectionStart, e.KeyChar.ToString()) + "1"))
                e.Handled = true;
        }

        private void Txt_DieDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!DateTime_Filter.IsMatch(Txt_DieDate.Text.Insert(Txt_DieDate.SelectionStart, e.KeyChar.ToString()) + "1"))
                e.Handled = true;
        }

        private void Txt_Points_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!NumbersOnly.IsMatch(Txt_Points.Text.Insert(Txt_Points.SelectionStart, e.KeyChar.ToString()) + "1"))
                e.Handled = true;
        }

        private void Screen_MemberCard_CellClick(object sender, DataGridViewCellEventArgs Event)
        {
            BTN_CreateNew.Enabled = false;
            BTN_Update.Enabled = true;
            BTN_Delete.Enabled = true;
            try
            {
#pragma warning disable
                Txt_Phone.Text = Screen_MemberCard.Rows[Event.RowIndex].Cells[0].Value.ToString().TrimEnd();
                Combo_Tier.Text = Screen_MemberCard.Rows[Event.RowIndex].Cells[2].Value.ToString();
                Txt_Available.Text = DateTime.Parse(Screen_MemberCard.Rows[Event.RowIndex].Cells[3].Value.ToString()).ToString("d/M/yyyy").Replace(", ", "/");
                Txt_DieDate.Text = DateTime.Parse(Screen_MemberCard.Rows[Event.RowIndex].Cells[4].Value.ToString()).ToString("d/M/yyyy").Replace(", ", "/");
#pragma warning enable
                Txt_Points.Text = Screen_MemberCard.Rows[Event.RowIndex].Cells[1].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                ResetAll();
                return;
            }
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Phone.Text) ||
                string.IsNullOrWhiteSpace(Combo_Tier.Text) ||
                string.IsNullOrWhiteSpace(Txt_Available.Text) ||
                string.IsNullOrWhiteSpace(Txt_DieDate.Text) ||
                string.IsNullOrWhiteSpace(Txt_Points.Text)
               )
            {
                MessageBox.Show("Thiếu thông tin", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!NumbersOnly.IsMatch(Txt_Phone.Text) || !NumbersOnly.IsMatch(Txt_Points.Text))
            {
                MessageBox.Show("Chỉ được điền số vào trường SĐT và điểm", "NO...........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var TTVCapNhat = new DAL.DomainClass.TheThanhVien();
            TTVCapNhat.SdtkhachHang = Txt_Phone.Text;
            TTVCapNhat.LoaiThanhVien = Combo_Tier.Text;
            TTVCapNhat.NgayHieuLuc = DateTime.Parse(Txt_Available.Text);
            TTVCapNhat.NgayHetHan = DateTime.Parse(Txt_DieDate.Text);
            TTVCapNhat.DiemThanhVien = int.Parse(Txt_Points.Text);
            Svc_TheThanhVien.Cap_Nhat(TTVCapNhat);
            MessageBox.Show("Cập nhật thành công", "DONEZO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetServiceList();
            ResetAll();
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            var TTVXoa = new DAL.DomainClass.TheThanhVien();
            TTVXoa.SdtkhachHang = Txt_Phone.Text;
            TTVXoa.LoaiThanhVien = Combo_Tier.Text;
            TTVXoa.NgayHieuLuc = DateTime.Parse(Txt_Available.Text);
            TTVXoa.NgayHetHan = DateTime.Parse(Txt_DieDate.Text);
            TTVXoa.DiemThanhVien = int.Parse(Txt_Points.Text);
            DialogResult Confirmation = MessageBox.Show("Do you want to delete????", "O H YEA  DELET TIEM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Confirmation == DialogResult.Yes)
            {
                if (TTVXoa.SdtkhachHang == Txt_Phone.Text &&
                TTVXoa.LoaiThanhVien == Combo_Tier.Text &&
                TTVXoa.NgayHieuLuc == DateTime.Parse(Txt_Available.Text) &&
                TTVXoa.NgayHetHan == DateTime.Parse(Txt_DieDate.Text) &&
                TTVXoa.DiemThanhVien == int.Parse(Txt_Points.Text)
                )
                {
                    Svc_TheThanhVien.Xoa(TTVXoa);
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
            GetServiceList();
            ResetAll();
        }
    }
}
