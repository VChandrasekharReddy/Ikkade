using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikkade.model
{
    public class Orders
    {
        public long OrderId { get; set; } = 0; // primary key
        public long BillerId { get; set; } = 0; // foreign key to Biller
        public Biller Biller { get; set; } = new Biller(); // navigation property to Biller
        public long ItemId { get; set; } = 0; // foreign key to Items
        public List<Items> items { get; set; } = new List<Items>(); // navigation property to Items
        public decimal TotalAmount { get; set; } = 0.0m;
        public DateTime OrderDate { get; set; } = DateTime.Now;

    }
}
