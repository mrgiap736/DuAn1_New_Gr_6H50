using DAL.Context;
using DAL.DomainClass;
using BUS.IServices;
using Microsoft.EntityFrameworkCore;

namespace BUS.Repositories
{
    public class Repository_DichVu : Interface_DichVu
    {
        public List<DichVu> TaiDuLieu()
        {
            using (var Context = new DBContext())
            {
                return Context.DichVus.ToList();
            }
        }

        public DichVu Them_Moi(DichVu Moi)
        {
            using (var Context = new DBContext())
            {
                Context.DichVus.Add(Moi);
                Context.SaveChanges();
                return Moi;
            }
        }

        public void Cap_Nhat(DichVu MucTieu)
        {
            if (MucTieu != null)
            {
                using (var Context = new DBContext())
                {
                    Context.Attach(MucTieu).State = EntityState.Modified;
                    Context.SaveChanges();
                }
            }
        }

        public void Xoa(DichVu MucTieu)
        {
            using (var Context = new DBContext())
            {
                Context.Attach(MucTieu);
                Context.Remove(MucTieu);
                Context.SaveChanges();
            }
        }
    }
}
