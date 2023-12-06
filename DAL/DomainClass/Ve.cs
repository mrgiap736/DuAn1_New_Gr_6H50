using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("Ve")]
    public partial class Ve
    {
        public Ve()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Key]
        [StringLength(10)]
        public string MaVe { get; set; } = null!;
        [StringLength(10)]
        public string MaPhim { get; set; } = null!;
        public int MaPhongChieu { get; set; }
        [StringLength(10)]
        public string MaGhe { get; set; } = null!;
        [StringLength(10)]
        public string MaLichChieu { get; set; } = null!;

        [ForeignKey("MaGhe")]
        [InverseProperty("Ves")]
        public virtual Ghe MaGheNavigation { get; set; } = null!;
        [ForeignKey("MaLichChieu")]
        [InverseProperty("Ves")]
        public virtual LichChieu MaLichChieuNavigation { get; set; } = null!;
        [ForeignKey("MaPhim")]
        [InverseProperty("Ves")]
        public virtual Phim MaPhimNavigation { get; set; } = null!;
        [ForeignKey("MaPhongChieu")]
        [InverseProperty("Ves")]
        public virtual PhongChieu MaPhongChieuNavigation { get; set; } = null!;
        [InverseProperty("MaVeNavigation")]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
