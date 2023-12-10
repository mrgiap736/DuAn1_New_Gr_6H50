using DAL.Context;
using DAL.DomainClass;
using DAL.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class Repository_ThongKe : Interface_ThongKe
    {
        public List<ThongKe> GetEverything()
        {
            using (var Context = new DBContext())
            {
                return Context.ThongKes.ToList();
            }
        }
    }
}
