using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOMS.Models
{
    public class Order
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string TransportId { get; set; }

        public TransportRFQ TransportRFQ { get; set; }

        public string OfferId { get; set; }

        public Offer Offer { get; set; }

        public string Comments { get; set; }
    }
}
