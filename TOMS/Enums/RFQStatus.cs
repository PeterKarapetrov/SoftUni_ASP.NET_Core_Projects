using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOMS.Enums
{
    public enum RFQStatus
    {
        WaitingOffers,
        Offered,
        Ordered,
        InTranzit,
        Delivered,
        Invoiced,
        Closed,
        Expired,
        Canceled
    }
}
