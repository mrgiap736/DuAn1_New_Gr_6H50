using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("TheThanhVien")]
    public partial class TheThanhVien
    {
        [Key]
        [Column("SDTKhachHang")]
        [StringLength(25)]
        public string SdtkhachHang { get; set; } = null!;
        public int? DiemThanhVien { get; set; }
        [StringLength(50)]
        public string? LoaiThanhVien { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayHieuLuc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NgayHetHan { get; set; }

        [ForeignKey("SdtkhachHang")]
        [InverseProperty("TheThanhVien")]
        public virtual KhachHang SdtkhachHangNavigation { get; set; } = null!;
    }
}
