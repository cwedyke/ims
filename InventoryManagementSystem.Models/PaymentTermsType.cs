using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    //todo: build dynamically from db table to ensure they are synced
    public enum PaymentTermsType
    {
        Net15 = 1,
        Net30 = 2,
        Net45 = 3,
        Net60 = 4,
        DueEndOfMonth = 5,
        DueEndOfNextMonth = 6,
        DueonReceipt = 7,
    }
}
