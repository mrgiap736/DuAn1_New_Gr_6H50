using DAL.DomainClass;

namespace DAL1.IRepos
{
    internal interface IVoucherRepo
    {
        public bool AddVc(Voucher vc);
        public List<Voucher> GetAllVC();
    }
}
