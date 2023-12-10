using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepos
{
    public interface Interface_DichVu
    {
        List<DichVu> TaiDuLieu();
        public DichVu Them_Moi(DichVu Moi);
        public void Cap_Nhat(DichVu MucTieu);
        public void Xoa(DichVu MucTieu);
    }
}
