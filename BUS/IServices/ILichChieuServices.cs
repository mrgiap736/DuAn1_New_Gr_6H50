using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ILichChieuServices
    {
        public List<LichChieu> GetAllLichChieu();
        public bool CreateLichChieu(LichChieu lc);
        public bool UpdateLichChieu(LichChieu lc);
        public bool DeleteLichChieu(string id);
        public List<string> GetNamePhim();
        public List<int> GetMaPhong();
    }
}
