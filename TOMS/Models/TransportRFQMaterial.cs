namespace TOMS.Models
{
    public class TransportRFQMaterial
    {
        public string TransportRFQId { get; set; }

        public TransportRFQ TransportRFQ { get; set; }

        public string MaterialId { get; set; }

        public Material Material { get; set; }
    }
}