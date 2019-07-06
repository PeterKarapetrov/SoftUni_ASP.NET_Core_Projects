using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOMS.Enums;

namespace TOMS.Models
{
    public class User
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Role> Roles { get; set; }

        public string CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<Offer> Offers { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Insurance> Insurances { get; set; }

        public ICollection<TransportRFQ> TransportRFQs { get; set; }
    }
}
