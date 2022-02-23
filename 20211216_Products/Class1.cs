using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211216_Products
{
    public class Product
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public bool Discount { get; set; }
        public bool Stock { get; set; }
        public int Variety { get; set; }
        public double Rating { get; set; }
        public bool Picture { get; set; }

        public Product()
        {
            this.Name = "Unnamed Product";
            this.Id = 0;
            this.Type = "Unknown Type";
            this.Price = 0;
            this.Discount = false;
            this.Stock = false;
            this.Variety = 0;
            this.Rating = 0;
            this.Picture = false;
        }

        
    }
}
