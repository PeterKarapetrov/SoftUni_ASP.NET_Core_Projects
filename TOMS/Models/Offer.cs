using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TOMS.Enums;

namespace TOMS.Models
{
    public class Offer
    {
        public string Id { get; set; }

        public DateTime SubmitionDate { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string TransportRFQId { get; set; }

        public TransportRFQ TransportRFQ { get; set; }

        [DataType(DataType.Date)]
        public DateTime LoadingDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }

        public decimal Price { get; set; }

        public Currency Currency { get; set; }

        public string Comments { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }
    }
}
