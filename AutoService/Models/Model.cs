using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    class Model
    {
        public Model(int id = 0, string name = "", Brand brand = null)
        {
            this.Id = id;
            this.Name = name;
            this.Brand = brand;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
    }
}
