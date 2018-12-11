using AutoService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoservice.Models
{
    class RepairCard
    {
        public RepairCard(int id, string number, DateTime dateIn, DateTime? dateOut, Car car, string description, Employee employee)
        {
            this.Id = id;
            this.Number = number;
            this.In = dateIn;
            this.Out = dateOut;
            this.Car = car;
            this.Description = description;
            this.Employee = employee;
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime In { get; set; }
        public DateTime? Out { get; set; }
        public Car Car { get; set; }
        public string Description { get; set; }
        public Employee Employee { get; set; }
        public List<SpareParts> parts { get; set; }
    }
}
