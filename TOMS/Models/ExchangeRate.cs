using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TOMS.Enums;

namespace TOMS.Models
{
    public class ExchangeRate
    {
        public string Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime ValidFrom { get; set; }

        [DataType(DataType.Date)]
        public DateTime ValidTo { get; set; }

        public Currency ExchageFrom { get; set; }

        public Currency ExchageTo { get; set; }

        public decimal Rate { get; set; }
    }
}
