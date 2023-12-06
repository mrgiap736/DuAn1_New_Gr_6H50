using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("Ghe")]
    public partial class Ghe
    {
        public Ghe()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        [StringLength(10)]
        public string MaGhe { get; set; } = null!;
        public int MaHangGhe { get; set; }
        [StringLength(20)]
        public string TrangThai { get; set; } = null!;

        [ForeignKey("MaHangGhe")]
        [InverseProperty("Ghes")]
        public virtual HangGhe MaHangGheNavigation { get; set; } = null!;
        [InverseProperty("MaGheNavigation")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
