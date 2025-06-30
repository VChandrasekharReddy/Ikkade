using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ikkade.model
{
    public class Biller
    {
        public long Id { get; set; } = 0; // primary key
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public List<Orders> Orders { get; set; } = new List<Orders>(); // navigation property to Orders
    }
}

