using DAL.Context;
using DAL.DomainClass;
using DAL.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class LichChieuRepos : ILichChieuRepos
    {
        DBContext db = new DBContext();
        public LichChieuRepos()
        {
                
        }
        public bool Create(LichChieu lc)
        {
            db.LichChieus.Add(lc);
            db.SaveChanges();
            return true;
        }

        public bool Delete(string id)
        {
            var lc = db.LichChieus.Find(id);
            
            db.LichChieus.Remove(lc);
            db.SaveChanges(); 
            return true;
        }

        public List<LichChieu> GetAll()
        {
            return db.LichChieus.Include(x => x.MaPhimNavigation).ToList();    
        }

        public List<string> GetAllP()
        {
            return db.Phims.Select(x => x.MaPhim).ToList();
        }

        public List<int> GetAllPhong()
        {
            return db.PhongChieus.Select(x => x.MaPhongChieu).ToList();
        }

        public bool Update(LichChieu lc)
        {
            throw new NotImplementedException();
        }
    }
}
