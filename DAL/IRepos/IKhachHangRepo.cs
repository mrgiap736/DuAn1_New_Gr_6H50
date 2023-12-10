using DAL.DomainClass;

namespace DAL1.IRepos
{
    public interface IKhachHangRepo
    {
        public bool AddKH(KhachHang kh);
        public bool UpdateKH(KhachHang kh);
        public bool RemoveKH(KhachHang kh);
        public List<KhachHang> GetAllKH();

    }
}
