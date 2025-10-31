using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPAssignment02_Final_
{
    public class Product
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public int price { get; set; }
        public int Qty { get; set; }

        public static List<Product> plist = new List<Product>();

    }
}
