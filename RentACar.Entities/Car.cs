using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int ModelYear { get; set; }
        public string CarImage { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
