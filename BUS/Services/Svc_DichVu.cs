using BUS.IServices;
using BUS.Repositories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class Svc_DichVu
    {
        static Interface_DichVu InterfaceDichVu;

        static Svc_DichVu()
        {
            InterfaceDichVu = new Repository_DichVu();
        }

        public static List<DichVu> TaiDuLieu()
        {
            return InterfaceDichVu.TaiDuLieu();
        }

        public static DichVu Them_Moi(DichVu Moi)
        {
            return InterfaceDichVu.Them_Moi(Moi);
        }

        public static void Cap_Nhat(DichVu MucTieu)
        {
            InterfaceDichVu.Cap_Nhat(MucTieu);
        }

        public static void Xoa(DichVu MucTieu)
        {
            InterfaceDichVu.Xoa(MucTieu);
        }
    }
}
