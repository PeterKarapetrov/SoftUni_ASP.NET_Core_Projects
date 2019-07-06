using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TOMS.Enums;

namespace TOMS.Models
{
    public class TransportRFQ
    {
        public string Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string CopyToEmail { get; set; }

        public string CompanySupplierId { get; set; }
        public Company CompanySupplier { get; set; }
        public string CompanyClientId { get; set; }
        public Company CompanyClient { get; set; }

        public ICollection<TransportRFQMaterial> TransortRFQMaterials { get; set; }

        [DataType(DataType.Date)]
        public DateTime ShipmentReadyDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime RequestDeliveryDate { get; set; }

        public int NumberOfPackages { get; set; }

        public string MaxPackageSize { get; set; }

        public double Volume { get; set; }

        public MeanOfTransport MeanOfTransport { get; set; }

        public MeanOfService MeanOfService { get; set; }

        [DataType(DataType.Date)]
        public DateTime ValidDate { get; set; }

        public string SpecialRequirements { get; set; }

        public RFQStatus Status { get; set; }


        public ICollection<Offer> Offers { get; set; }

        public string OrderId { get; set; }
        public Order Order { get; set; }

        public string InsuranceId { get; set; }

        public Insurance Insurance {get; set;}
    }
}
