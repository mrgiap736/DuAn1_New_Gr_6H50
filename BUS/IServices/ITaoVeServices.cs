using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ITaoVeServices
    {
        public List<Ve> GetAllVe();
        public bool TaoVeMoi(Ve ve);
        public LichChieu GetLC(string maphim);

    }
}
