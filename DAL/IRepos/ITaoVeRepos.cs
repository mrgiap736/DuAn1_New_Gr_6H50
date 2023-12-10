using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepos
{
    public interface ITaoVeRepos
    {
        public List<Ve> GetAll();
        public bool Create(Ve ve);
        public LichChieu GetLC(string maphim);
    }
}
