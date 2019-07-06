using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOMS.Models
{
    public class Service
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<CompanyService> CompanyServices { get; set; }
    }
}
