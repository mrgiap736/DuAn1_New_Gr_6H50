﻿using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IPhimServices
    {
        public List<Phim> GetAllPhim();
        public List<Ghe> GetAllGhe();
    }
}
