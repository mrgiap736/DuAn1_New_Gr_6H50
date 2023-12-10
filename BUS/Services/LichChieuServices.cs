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
    public class LichChieuServices : ILichChieuServices
    {
        LichChieuRepos rp = new LichChieuRepos();

        public LichChieuServices()
        {
                
        }
        public bool CreateLichChieu(LichChieu lc)
        {
            return rp.Create(lc);
        }

        public bool DeleteLichChieu(string id)
        {
            rp.Delete(id);
            return true;
        }

        public List<LichChieu> GetAllLichChieu()
        {
            return rp.GetAll();
        }

        public List<int> GetMaPhong()
        {
            return rp.GetAllPhong();
        }

        public List<string> GetNamePhim()
        {
            return rp.GetAllP();
        }

        public bool UpdateLichChieu(string malc, string maphim, int maphongchieu, DateTime thoigianchieu)
        {
            rp.Update(malc, maphim, maphongchieu, thoigianchieu);
            return true;
        }
    }
}
