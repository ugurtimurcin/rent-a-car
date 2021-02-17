using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public int CarModelYear { get; set; }
        public string CarImage { get; set; }
        public decimal CarDailyPrice { get; set; }
        public string CarDescription { get; set; }
        public string CarColor { get; set; }
        public string CarBrand { get; set; }
    }
}
