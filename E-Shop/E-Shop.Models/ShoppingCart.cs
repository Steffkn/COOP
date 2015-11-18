using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        private Dictionary<Product, int> products;
        
        public ShoppingCart()
        {
            this.products = new Dictionary<Product, int>();
        }

        public Dictionary<Product, int> Products { get { return this.products; } set { this.products = value; } }
    }
}
