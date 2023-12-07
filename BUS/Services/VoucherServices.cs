using BUS.IServices;
using DAL.DomainClass;
using DAL1.Repos;

namespace BUS.Services
{
    public class VoucherServices : IVoucherServices
    {
        private VoucherRepo _Repos;

        public VoucherServices()
        {
            _Repos = new VoucherRepo();
        }

        public string Add(Voucher vc)
        {

            if (_Repos.AddVc(vc) == null)
            {
                return " Tạo Thất Bại";
            }
            else
            {
               
                return " Tạo Thành Công";
            }

        }

        public List<Voucher> GetAllVCs()
        {
            return _Repos.GetAllVC();
        }
    }
}
