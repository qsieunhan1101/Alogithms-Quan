using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alogithms_Quan
{
    internal class Product 
    {
        string name;
        int price;
        int quantity;
        int categoryId;

        public Product() { }
        public Product(string name, int price, int quantity, int categoryId)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.CategoryId = categoryId;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
    }
}
