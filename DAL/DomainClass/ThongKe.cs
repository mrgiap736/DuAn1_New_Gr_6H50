using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass
{
    [Table("ThongKe")]
    public partial class ThongKe
    {
        [Key]
        [StringLength(10)]
        public string MaThongKe { get; set; } = null!;
        public int? DoanhThuPhimNgay { get; set; }
        public int? DoanhThuDichVuNgay { get; set; }
        public int? SoVeDaBan { get; set; }
    }
}
