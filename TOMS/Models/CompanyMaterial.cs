namespace TOMS.Models
{
    public class CompanyMaterial
    {
        public string CompanyId { get; set; }

        public Company Compny { get; set; }

        public string MaterialId { get; set; }

        public Material Material { get; set; }
    }
}