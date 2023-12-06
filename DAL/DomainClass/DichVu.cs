using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("DichVu")]
    public partial class DichVu
    {
        public DichVu()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(10)]
        public string MaDichVu { get; set; } = null!;
        [StringLength(50)]
        public string TenDichVu { get; set; } = null!;
        public int GiaDichVu { get; set; }
        [StringLength(50)]
        public string TrangThaiDichVu { get; set; } = null!;

        [InverseProperty("MaDichVuNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
