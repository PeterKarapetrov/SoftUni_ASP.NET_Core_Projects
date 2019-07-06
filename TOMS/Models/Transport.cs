using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOMS.Models
{
    public class Transport
    {
        public string Id { get; set; }

        public string MeansOf { get; set; }

        public ICollection<CompanyTransport> CompanyTransports { get; set; }
    }
}
