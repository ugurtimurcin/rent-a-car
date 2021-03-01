using RentACar.Core.Entities;
using RentACar.Core.Entities.Concrete;
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

        public int UserId { get; set; }
        public User AppUser { get; set; }
    }
}
