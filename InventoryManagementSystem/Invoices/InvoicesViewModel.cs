using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Common.Core;

namespace InventoryManagementSystem.Invoices
{
    public class InvoicesViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Invoices Page";
            }
        }
    }
}
