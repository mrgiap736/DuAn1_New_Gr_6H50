using DAL.DomainClass;

namespace BUS.IServices
{
    internal interface IKhachHangServices
    {
        public string Add(KhachHang kh);
        public string Update(KhachHang kh);
        public string Remove(KhachHang kh);
        List<KhachHang> GetAll(string search);
    }
}
