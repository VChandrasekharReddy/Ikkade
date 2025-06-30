using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.model
{
    public class Items
    {
        public long ItemId { get; set; } = 0; // primary key
        public string ItemName { get; set; } = string.Empty;
        public string ItemDscription { get; set; } = string.Empty;
        public decimal ItemPrice { get; set; } = 0.0m;
        public long OrderId { get; set; } = 0; // foreign key to Orders
        public Orders Order { get; set; } = new Orders(); // navigation property to Orders

    }
}
