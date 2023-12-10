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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            Get_Information();
        }
        public Panel thongKe()
        {
            return panel_Thongke;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void Get_Information()
        {
            dataGridView1.DataSource = Svc_ThongKe.GetEverything();
        }
    }
}
