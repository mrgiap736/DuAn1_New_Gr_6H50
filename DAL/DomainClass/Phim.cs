using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("Phim")]
    public partial class Phim
    {
        public Phim()
        {
            LichChieus = new HashSet<LichChieu>();
            Ves = new HashSet<Ve>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhim { get; set; } = null!;
        [StringLength(50)]
        public string TenPhim { get; set; } = null!;
        [StringLength(30)]
        public string? NgonNgu { get; set; }
        [StringLength(10)]
        public string MaTheLoai { get; set; } = null!;
        [StringLength(10)]
        public string MaDaoDien { get; set; } = null!;
        [StringLength(10)]
        public string MaDienVien { get; set; } = null!;
        [StringLength(150)]
        public string? MoTa { get; set; }
        [StringLength(10)]
        public string? Rated { get; set; }
        [Column(TypeName = "date")]
        public DateTime NgayPhatHanh { get; set; }
        public int? ThoiLuong { get; set; }

        [ForeignKey("MaDaoDien")]
        [InverseProperty("Phims")]
        public virtual DaoDien MaDaoDienNavigation { get; set; } = null!;
        [ForeignKey("MaDienVien")]
        [InverseProperty("Phims")]
        public virtual DienVien MaDienVienNavigation { get; set; } = null!;
        [ForeignKey("MaTheLoai")]
        [InverseProperty("Phims")]
        public virtual TheLoai MaTheLoaiNavigation { get; set; } = null!;
        [InverseProperty("MaPhimNavigation")]
        public virtual ICollection<LichChieu> LichChieus { get; set; }
        [InverseProperty("MaPhimNavigation")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
