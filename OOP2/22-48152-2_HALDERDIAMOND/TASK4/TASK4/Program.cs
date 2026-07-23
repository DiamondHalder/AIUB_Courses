using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TASK4
{
    internal class Program
    {
        public class Vehicle
        {
            private string vehicleName;
            private string vehicleId;

            public static int vehicleCount = 0;

            // Properties
            public string VehicleName
            {
                get { return vehicleName; }
                set { vehicleName = value; }
            }

            public string VehicleId
            {
                get { return vehicleId; }
                set { vehicleId = value; }
            }

            // Constructor
            public Vehicle(string name, string id)
            {
                VehicleName = name;
                VehicleId = id;
                vehicleCount++;
                Console.WriteLine("Vehicle object created.");
            }

            // Member functions
            public virtual void status()
            {
                Console.WriteLine("Vehicle is running.");
            }

            public void showInfo()
            {
                Console.WriteLine($"Vehicle Name: {VehicleName}, Vehicle ID: {VehicleId}");
            }
        }

        public class Motorbike : Vehicle
        {
            // Constructor
            public Motorbike(string name, string id) : base(name, id)
            {
                Console.WriteLine("Motorbike object created.");
            }

            // Member function
            public override void status()
            {
                Console.WriteLine("Motorbike is running.");
            }
        }

        public class Truck : Vehicle
        {
            // Constructor
            public Truck(string name, string id) : base(name, id)
            {
                Console.WriteLine("Truck object created.");
            }

            // Member function
            public override void status()
            {
                Console.WriteLine("Truck is running.");
            }
        }

        public class Car : Vehicle
        {
            // Constructor
            public Car(string name, string id) : base(name, id)
            {
                Console.WriteLine("Car object created.");
            }

            // Member function
            public override void status()
            {
                Console.WriteLine("Car is running.");
            }
        }

        public class Saloon : Car
        {
            // Constructor
            public Saloon(string name, string id) : base(name, id)
            {
                Console.WriteLine("Saloon object created.");
            }

            // Member function
            public override void status()
            {
                Console.WriteLine("Saloon is running.");
            }
        }

        public class MPV : Vehicle
        {
            // Constructor
            public MPV(string name, string id) : base(name, id)
            {
                Console.WriteLine("MPV object created.");
            }

            // Member function
            public override void status()
            {
                Console.WriteLine("MPV is running.");
            }
        }

        static void Main(string[] args)
        {
            Vehicle obj1 = new Motorbike("Yamaha", "M123");
            Vehicle obj2 = new Truck("Volvo", "T456");
            Vehicle obj3 = new MPV("Toyota", "MP789");

            obj1.showInfo();
            obj2.showInfo();
            obj3.showInfo();

            obj1.status();
            obj2.status();
            obj3.status();
        }
    }
}

