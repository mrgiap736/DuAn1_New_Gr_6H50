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
    public class YCDichVuSV : IYCDichVuSV
    {
        YCDichVuRepos repo = new YCDichVuRepos();
        public YCDichVuSV()
        {

        }
        public List<DichVu> GetAllDV()
        {
            return repo.GetAll();
        }
    }
}
