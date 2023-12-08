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
    public class PhimRepos : IPhimRepos
    {
        DBContext db = new DBContext();

        public PhimRepos()
        {
                
        }
        public List<Phim> GetAll()
        {
            return db.Phims.ToList();
        }
    }
}
