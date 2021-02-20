using RentACar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
