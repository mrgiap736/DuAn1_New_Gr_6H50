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
    public class Svc_TheThanhVien
    {
        static Interface_TheThanhVien InterfaceTheThanhVien;

        static Svc_TheThanhVien()
        {
            InterfaceTheThanhVien = new Repository_TheThanhVien();
        }

        public static List<TheThanhVien> Tai_Du_Lieu()
        {
            return InterfaceTheThanhVien.Tai_Du_Lieu();
        }

        public static TheThanhVien Them_Moi(TheThanhVien Moi)
        {
            return InterfaceTheThanhVien.Them_Moi(Moi);
        }

        public static void Cap_Nhat(TheThanhVien MucTieu)
        {
            InterfaceTheThanhVien.Cap_Nhat(MucTieu);
        }

        public static void Xoa(TheThanhVien MucTieu)
        {
            InterfaceTheThanhVien.Xoa(MucTieu);
        }
    }
}
