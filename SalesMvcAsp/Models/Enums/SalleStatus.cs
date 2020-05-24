using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMvcAsp.Models.Enums
{
    public enum SalleStatus : int
    {
        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}
