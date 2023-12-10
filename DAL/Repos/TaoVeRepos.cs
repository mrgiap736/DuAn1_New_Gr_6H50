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
    public class TaoVeRepos : ITaoVeRepos
    {
        DBContext db = new DBContext();
        public TaoVeRepos()
        {
                
        }
        public bool Create(Ve ve)
        {
            db.Ves.Add(ve);
            db.SaveChanges();
            return true;
        }

        public List<Ve> GetAll()
        {
            return db.Ves.Include("MaLichChieuNavigation").ToList();
        }

        public LichChieu GetLC(string maphim)
        {
            // Giả sử db là đối tượng của DbContext (Entity Framework)
            var lichChieu = db.LichChieus
                .Where(lc => lc.MaPhim == maphim) // Giả sử MaNhom là khóa ngoại trỏ đến Phim
                .FirstOrDefault();

            return lichChieu;
        }
    }
}
