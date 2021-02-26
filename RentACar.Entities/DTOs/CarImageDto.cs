using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities.DTOs
{
    public class CarImageDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
    }
}
