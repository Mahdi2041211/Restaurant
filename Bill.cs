using Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
