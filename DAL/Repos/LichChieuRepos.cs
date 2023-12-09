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
            try
            {
                db.LichChieus.Add(lc);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false; 
            }

        }

        public bool Delete(string id)
        {
            try
            {
                var lc = db.LichChieus.Find(id);

                db.LichChieus.Remove(lc);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
            
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

        public bool Update(string malc, string maphim, int maphongchieu, DateTime thoigianchieu)
        {
            try
            {
                var lc = db.LichChieus.Find(malc);

                lc.MaPhim = maphim;
                lc.MaPhongChieu = maphongchieu;
                lc.ThoiGianChieu = thoigianchieu;

                db.LichChieus.Update(lc);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return false;
            }
            
        }
    }
}
