using BUS.Services;

namespace PRL.User_Interfaces
{
    public partial class KhachHang : Form
    {
        private KhachHangServices _service;
        private List<DAL.DomainClass.KhachHang> _listKH;
        private string _IDwhenclick;
        public KhachHang()
        {
            InitializeComponent();
            _service = new KhachHangServices();
            LoadGird(null);
        }
        public Panel khachHang()
        {
            return Panel_khachHang;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }
        public void LoadGird(string search)
        {
            int stt = 1;
            dtgview.Rows.Clear();
            dtgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgview.ColumnCount = 4;
            dtgview.Columns[0].Name = "STT";
            dtgview.Columns[1].Name = "Tên Khách Hàng";
            dtgview.Columns[2].Name = "Địa chỉ";
            dtgview.Columns[3].Name = "Số Điện Thoại"; // Sửa chỉ số cột thành 3, bắt đầu từ 0
            dtgview.Rows.Clear();
            _listKH = _service.GetAll(search);
            // Gán dữ liệu từ service vào _listKH
            foreach (var kh in _service.GetAll(txtSearch.Text))
            {
                dtgview.Rows.Add(stt++, kh.TenKhachHang, kh.DiaChi, kh.SdtkhachHang);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var kh = new DAL.DomainClass.KhachHang();
            kh.TenKhachHang = txtTen.Text;
            kh.DiaChi = txtDiachi.Text;
            kh.SdtkhachHang = txtSDT.Text;

            var option = MessageBox.Show("Xác nhận muốn thêm khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Add(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var kh = new DAL.DomainClass.KhachHang();

            kh.SdtkhachHang = _IDwhenclick;
            var option = MessageBox.Show("Xác nhận muốn Xoá khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Remove(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var kh = new DAL.DomainClass.KhachHang();

            kh.SdtkhachHang = _IDwhenclick;
            var option = MessageBox.Show("Xác nhận muốn sửa khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_service.Update(kh));
                LoadGird(null);
            }
            else
            {
                return;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGird(null);
        }

        private void dtgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _listKH.Count)
            {
                return;
            }
            var obj = _listKH[index];
            _IDwhenclick = obj.SdtkhachHang;
            txtTen.Text = obj.TenKhachHang;
            txtDiachi.Text = obj.DiaChi;
           
            txtSDT.Text = obj.SdtkhachHang;
            
        }
    }
}
