using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(10)]
        public string MaHoaDon { get; set; } = null!;
        [StringLength(20)]
        public string HinhThucThanhToan { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ThoiGianThanhToan { get; set; }
        [StringLength(20)]
        public string TrangThaiThanhToan { get; set; } = null!;
        [Column("SDTKhachHang")]
        [StringLength(25)]
        public string SdtkhachHang { get; set; } = null!;
        [StringLength(10)]
        public string? MaVoucher { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ThoiGianXacNhanHoaDon { get; set; }

        [ForeignKey("MaVoucher")]
        [InverseProperty("HoaDons")]
        public virtual Voucher? MaVoucherNavigation { get; set; }
        [ForeignKey("SdtkhachHang")]
        [InverseProperty("HoaDons")]
        public virtual KhachHang SdtkhachHangNavigation { get; set; } = null!;
        [InverseProperty("MaHoaDonNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
