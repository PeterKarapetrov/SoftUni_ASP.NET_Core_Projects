using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TOMS.Enums;

namespace TOMS.Models
{
    public class Insurance
    {
        public string Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime SubmitionDate { get; set; }

        public string SendToEmail { get; set; }
        public string TransportRFQId { get; set; }

        public TransportRFQ TransportRFQ { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public decimal InsuranceAmout { get; set; }

        public Currency Currency { get; set; }

        public string Comments { get; set; }
    }
}
