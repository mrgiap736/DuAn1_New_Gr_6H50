using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("TheLoai")]
    public partial class TheLoai
    {
        public TheLoai()
        {
            Phims = new HashSet<Phim>();
        }

        [Key]
        [StringLength(10)]
        public string MaTheLoai { get; set; } = null!;
        [StringLength(20)]
        public string TenTheLoai { get; set; } = null!;

        [InverseProperty("MaTheLoaiNavigation")]
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
