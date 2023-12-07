using BUS.IServices;
using DAL.Context;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repositories
{
    public class Repository_TheThanhVien : Interface_TheThanhVien
    {
        public List<TheThanhVien> Tai_Du_Lieu()
        {
            using (var Context = new DBContext())
            {
                return Context.TheThanhViens.ToList();
            }
        }

        public TheThanhVien Them_Moi(TheThanhVien Moi)
        {
            using (var Context = new DBContext())
            {
                Context.TheThanhViens.Add(Moi);
                Context.SaveChanges();
                return Moi;
            }
        }

        public void Cap_Nhat(TheThanhVien MucTieu)
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
        public void Xoa(TheThanhVien MucTieu)
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
