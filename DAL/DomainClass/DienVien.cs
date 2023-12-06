using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("DienVien")]
    public partial class DienVien
    {
        public DienVien()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [StringLength(10)]
        public string MaDienVien { get; set; } = null!;
        [StringLength(30)]
        public string TenDienVien { get; set; } = null!;
        [StringLength(150)]
        public string? MoTaDienVien { get; set; }

        [InverseProperty("MaDienVienNavigation")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
