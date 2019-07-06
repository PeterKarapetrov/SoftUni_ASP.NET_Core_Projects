using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOMS.Enums;

namespace TOMS.Models
{
    public class Company
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string CompanyUIC { get; set; }
        public string CompanyVATNumber { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string ZIPCode { get; set; }

        public string Address { get; set; }

        public string UserId { get; set; }

        public ICollection<User> Users { get; set; }

        public string WorkingHours { get; set; }

        public string SpecialRequirements { get; set; }

        public CompanyType CompanyType { get; set; }

        public ICollection<CompanyMaterial> CompanyMaterils { get; set; }

        public ICollection<CompanyTransport> CompanyTransports { get; set; }

        public ICollection<CompanyService> CompanyServices { get; set; }
    }
}
