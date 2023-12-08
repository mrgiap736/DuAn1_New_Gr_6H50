using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepos
{
    public interface ILichChieuRepos
    {
        public List<LichChieu> GetAll();
        public bool Create(LichChieu lc);
        public bool Update(LichChieu lc);
        public bool Delete(string id);
        public List<string> GetAllP();
        public List<int> GetAllPhong();
    }
}
