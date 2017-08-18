using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Common.Core;

namespace InventoryManagementSystem.Dashboard
{
    public class DashboardViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Dashboard Page";
            }
        }
    }
    
}
