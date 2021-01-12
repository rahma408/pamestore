using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamelstore.Isi
{
    public class Item
    {
        public string item { get; set; }
        public double price { get; set; }

        public Item(string item, double price)
        {
            this.item = item;
            this.price = price;
        }
    }
}
