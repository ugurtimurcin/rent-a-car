using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public string ImagePath { get; set; } = "default.jpg";
        public DateTime DateTime { get; set; } = DateTime.Now;

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
