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
    public class YCDichVuRepos : IYCDichVuRepos

    {
        DBContext context = new DBContext();

        public YCDichVuRepos()
        {

        }
        public List<DichVu> GetAll()
        {
            return context.DichVus.ToList();
        }
    }
}
