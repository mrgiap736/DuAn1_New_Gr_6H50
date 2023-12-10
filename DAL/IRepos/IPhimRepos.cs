using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepos
{
    public interface IPhimRepos
    {
        public List<Phim> GetAll();
        public List<Ghe> GetAllGhe();
    }
}
