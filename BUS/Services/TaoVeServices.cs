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
    public class TaoVeServices : ITaoVeServices
    {
        TaoVeRepos rp = new TaoVeRepos();
        public TaoVeServices()
        {
                
        }
        public List<Ve> GetAllVe()
        {
            return rp.GetAll();
        }

        public LichChieu GetLC(string maphim)
        {
            return rp.GetLC(maphim);
        }

        public bool TaoVeMoi(Ve ve)
        {
            rp.Create(ve);
            return true;
        }
    }
}
