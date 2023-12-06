using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("SDTKhachHang")]
        [StringLength(25)]
        public string SdtkhachHang { get; set; } = null!;
        [StringLength(50)]
        public string TenKhachHang { get; set; } = null!;
        [StringLength(150)]
        public string? DiaChi { get; set; }

        [InverseProperty("SdtkhachHangNavigation")]
        public virtual TheThanhVien? TheThanhVien { get; set; }
        [InverseProperty("SdtkhachHangNavigation")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
