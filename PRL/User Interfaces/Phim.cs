using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRL.User_Interfaces
{
    public partial class Phim : Form
    {
        public Phim()
        {
            InitializeComponent();

            // Đặt giá trị lớn nhất của thanh trượt là chiều cao của Panel
            VSBphim.Maximum = Panel_Phim.Height;
        }


        private void VSBphim_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = VSBphim.Value;

            Panel_Phim.Top = -scrollValue;


        }

        private void Panel_Phim_SizeChanged(object sender, EventArgs e)
        {
            VSBphim.Maximum = Panel_Phim.Height;
        }
        public Panel phim()
        {
            return Panel_Scroll;
        }

        
    }
}
