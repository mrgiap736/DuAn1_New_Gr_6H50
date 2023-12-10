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
    public class ThongKeSV
    {
        static IThongKe I_ThongKe;

        static ThongKeSV()
        {
            I_ThongKe = new ThongKeRepo();
        }

        public static List<ThongKe> GetAllTK()
        {
            return I_ThongKe.GetAll();
        }
    }
}
