using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("HangGhe")]
    public partial class HangGhe
    {
        public HangGhe()
        {
            Ghes = new HashSet<Ghe>();
        }

        [Key]
        public int MaHangGhe { get; set; }
        [StringLength(20)]
        public string TenHangGhe { get; set; } = null!;
        public int GiaHangGhe { get; set; }

        [InverseProperty("MaHangGheNavigation")]
        public virtual ICollection<Ghe> Ghes { get; set; }
    }
}
