using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("LichChieu")]
    public partial class LichChieu
    {
        public LichChieu()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        [StringLength(10)]
        public string MaLichChieu { get; set; } = null!;
        [StringLength(10)]
        public string MaPhim { get; set; } = null!;
        public int MaPhongChieu { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ThoiGianChieu { get; set; }

        [ForeignKey("MaPhim")]
        [InverseProperty("LichChieus")]
        public virtual Phim MaPhimNavigation { get; set; } = null!;
        [ForeignKey("MaPhongChieu")]
        [InverseProperty("LichChieus")]
        public virtual PhongChieu MaPhongChieuNavigation { get; set; } = null!;
        [InverseProperty("MaLichChieuNavigation")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
