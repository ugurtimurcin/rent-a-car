using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
