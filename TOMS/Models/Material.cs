using System.Collections.Generic;
using TOMS.Enums;

namespace TOMS.Models
{
    public class Material
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Package Package { get; set; }

        public HazardClass Hazard { get; set; }

        public ICollection<CompanyMaterial> CompanyMaterials { get; set; }

        public ICollection<TransportRFQMaterial> TransportRFQMaterials { get; set; }

    }
}