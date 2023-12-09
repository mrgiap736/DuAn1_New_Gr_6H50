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
        private string maghe { get; set; }
        public TaoVe(string maghe)
        {
            InitializeComponent();
            this.maghe = maghe;
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
    }
}
