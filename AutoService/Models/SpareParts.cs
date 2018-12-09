using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    class SpareParts
    {
        public SpareParts(int id = 0, string name = "", string number = "", double price = 0)
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
            this.Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public double Price { get; set; } 
    }
}
