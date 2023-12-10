using BUS.Services;
using DAL.DomainClass;

namespace PRL.User_Interfaces
{
    public partial class Vouchers : Form
    {
        private VoucherServices _services;
        List<DAL.DomainClass.Voucher> _listVc = new();
        private string _IDwhenclick;
        public Vouchers()
        {
            InitializeComponent();
            _services = new VoucherServices();
            LoadData(null);
        }
        public Panel Voucher()
        {
            return panel_Voucher;

        }

        private void Vouchers_Load(object sender, EventArgs e)
        {

        }

        private void btn_TaoVoucher_Click(object sender, EventArgs e)
        {
            var vc = new Voucher();
            vc.MaVoucher = txt_maVoucher.Text;
            vc.LoaiVoucher = txt_loaiVoucher.Text;
            vc.GiaTri = int.Parse(txt_GiaTri.Text);
            vc.HanSuDung = DateTime.Parse(txt_HanSuDung.Text);
            var option = MessageBox.Show("Xác nhận muốn thêm vcách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_services.Add(vc));
                LoadData(null);
            }
            else
            {
                return;
            }

        }
        public void LoadData(string search)
        {
            int stt = 1;
            dtgView.ColumnCount = 5;
            dtgView.Columns[0].Name = "Stt";
            dtgView.Columns[1].Name = "MaVoucher";
            dtgView.Columns[2].Name = "LoaiVoucher";
            dtgView.Columns[3].Name = "GiaTri";
            dtgView.Columns[4].Name = "HanSuDung";

            dtgView.Rows.Clear();
            _listVc = _services.GetAllVCs();
            foreach (var vc in _listVc)
            {
                dtgView.Rows.Add(stt++, vc.MaVoucher, vc.LoaiVoucher, vc.GiaTri, vc.HanSuDung);
            }


        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            // Xóa hoặc làm sạch dữ liệu trên các điều vciển

            // Xóa hoặc xóa trống TextBoxes
            txt_maVoucher.Text = string.Empty;
            txt_loaiVoucher.Text = string.Empty;
            txt_GiaTri.Text = string.Empty;
            txt_HanSuDung.Text = string.Empty;

            // Xóa hoặc làm sạch DataGridView
            dtgView.Rows.Clear(); // Xóa hết dữ liệu trong DataGridView

            // Hoặc có thể gọi phương thức LoadData hoặc LoadGird để tải lại dữ liệu mặc định
            LoadData(null); // Gọi lại phương thức để tải dữ liệu mặc định
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _listVc.Count)
            {
                return;
            }
            var obj = _listVc[index];
            _IDwhenclick = obj.MaVoucher;
            txt_maVoucher.Text = obj.MaVoucher;
            txt_loaiVoucher.Text = obj.LoaiVoucher;
            txt_GiaTri.Text = obj.GiaTri.ToString();
            txt_HanSuDung.Text = obj.HanSuDung.ToString();

        }
    }

}
