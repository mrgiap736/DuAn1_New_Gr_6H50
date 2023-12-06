using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        [StringLength(10)]
        public string MaHoaDonChiTiet { get; set; } = null!;
        [StringLength(10)]
        public string MaHoaDon { get; set; } = null!;
        [StringLength(10)]
        public string? MaVe { get; set; }
        [StringLength(10)]
        public string? MaDichVu { get; set; }
        public int? SoLuongVe { get; set; }
        public int? TongTien { get; set; }

        [ForeignKey("MaDichVu")]
        [InverseProperty("HoaDonChiTiets")]
        public virtual DichVu? MaDichVuNavigation { get; set; }
        [ForeignKey("MaHoaDon")]
        [InverseProperty("HoaDonChiTiets")]
        public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
        [ForeignKey("MaVe")]
        [InverseProperty("HoaDonChiTiets")]
        public virtual Ve? MaVeNavigation { get; set; }
    }
}
