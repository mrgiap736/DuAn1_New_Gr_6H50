    using DAL.DomainClass;

namespace BUS.IServices
{
    internal interface IVoucherServices
    {
        public string Add(Voucher vc);
        List<Voucher> GetAllVCs();
    }
}
