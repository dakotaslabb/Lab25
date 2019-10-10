using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab25.Models
{
    public class Purchase
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }

        public Purchase()
        {

        }

        public Purchase(string Name, double Price, double Quantity, string Description)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Description = Description;
        }
    }
}
