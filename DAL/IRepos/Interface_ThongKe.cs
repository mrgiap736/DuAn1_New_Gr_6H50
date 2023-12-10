using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepos
{
    public interface Interface_ThongKe
    {
        public List<ThongKe> GetEverything();
    }
}
