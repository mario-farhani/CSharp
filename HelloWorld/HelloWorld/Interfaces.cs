using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public void Report();

    }
    class Interfaces
    {
        public void InterfacesFunc()
        {
            IVehicle myCar = new Car();
            IVehicle myTruck = new Truck();

            myCar.Model = "X1";
            myCar.Make = "BMW";
            myCar.Year = " 2013";

            myTruck.Model = "LP6088";
            myTruck.Make = "Mercedes";
            myTruck.Year = "1986";

            myCar.Report();
            myTruck.Report();

        }
      
    }

    class Car : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        private int Wheels = 4;
        public void Report()
        {
            Console.WriteLine($"Make: {this.Make} Model: {this.Model} Year: {this.Year} has {this.Wheels} Wheels");
        }
    }
    class Truck : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        private int Wheels = 6;
        public void Report()
        {
            Console.WriteLine($"Make: {this.Make} Model: {this.Model} Year: {this.Year} has {this.Wheels} Wheels");
        }
    }
}
