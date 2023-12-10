using DAL.DomainClass;
using DAL.IRepos;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class Svc_ThongKe
    {
        static Interface_ThongKe InterfaceThongKe;

        static Svc_ThongKe()
        {
            InterfaceThongKe = new Repository_ThongKe();
        }

        public static List<ThongKe> GetEverything()
        {
            return InterfaceThongKe.GetEverything();
        }
    }
}
