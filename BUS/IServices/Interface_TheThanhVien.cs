using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface Interface_TheThanhVien
    {
        public List<TheThanhVien> Tai_Du_Lieu();
        public TheThanhVien Them_Moi(TheThanhVien Moi);
        public void Cap_Nhat(TheThanhVien MucTieu);
        public void Xoa(TheThanhVien MucTieu);
    }
}
