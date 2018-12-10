using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    class Car
    {
        public Car(int id, string number) : this(id, number, null, 0, "", "", null, "", "", "", "")
        {
        }

        public Car(int id, string registrationNumber,
            Model model, int year, string engineNumber,
            string frameNumber, CarColor color, string engineVolume,
            string description, string carOwnerName, string contactNumber)
        {
            this.Id = id;
            this.RegistrationNumber = registrationNumber;
            this.Model = model;
            this.Year = year;
            this.EngineNumber = engineNumber;
            this.FrameNumber = frameNumber;
            this.Description = description;
            this.Color = color;
            this.EngineVolume = engineVolume;
            this.Description = description;
            this.CarOwnerName = carOwnerName;
            this.ContactNumber = contactNumber;
        }

        public int Id { get; set; }
        public string RegistrationNumber { set; get; }
        public Model Model { set; get; }
        public int Year { set; get; }
        public string EngineNumber { set; get; }
        public string FrameNumber { set; get; }
        public CarColor Color { set; get; }
        public string EngineVolume { set; get; }
        public string Description { set; get; }
        public string CarOwnerName { set; get; }
        public string ContactNumber { set; get; }



    }
}
