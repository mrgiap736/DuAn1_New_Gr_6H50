using BUS.IServices;
using DAL.DomainClass;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class PhimServices : IPhimServices
    {
        PhimRepos rp = new PhimRepos();

        public PhimServices()
        {
                
        }
        public List<Phim> GetAllPhim()
        {
            return rp.GetAll();
        }
    }
}
