﻿using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public int ModelYear { get; set; }
        public string CarImage { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }
}