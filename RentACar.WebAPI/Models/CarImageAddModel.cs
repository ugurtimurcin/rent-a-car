using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Models
{
    public class CarImageAddModel
    {
        public int CarId { get; set; }
        public string ImagePath { get; set; } = "default.jpg";
        public IFormFile Image{ get; set; }
    }
}
