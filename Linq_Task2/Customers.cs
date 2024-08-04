using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Task2
{
    internal class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string City { get; set;}

        public List<Product> PurchasedProducts { get; set; } = new List<Product>();
    }
}
