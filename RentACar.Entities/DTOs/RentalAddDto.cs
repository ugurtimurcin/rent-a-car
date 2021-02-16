using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities.DTOs
{
    public class RentalAddDto : IDto
    {
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int AppUserId { get; set; }

        public int CarId { get; set; }
    }
}
