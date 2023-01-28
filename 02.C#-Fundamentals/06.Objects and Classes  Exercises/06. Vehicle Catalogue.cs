using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Vehicle> catalog = new List<Vehicle>();
            CatalogAddVehicle(catalog);
            CatalogPrint(catalog);

            List<Vehicle> Cars = catalog.Where(x => x.TypeOfVehicle == "car").ToList();
            List<Vehicle> Trucks = catalog.Where(x => x.TypeOfVehicle == "truck").ToList();

            if (Cars.Count > 0)
            {
                double carsAvrHp = Cars.Sum(x => x.HorsePower) / (double)Cars.Count;
                Console.WriteLine($"Cars have average horsepower of: {carsAvrHp:f2}.");
            }
            else
                Console.WriteLine("Cars have average horsepower of: 0.00.");

            if (Trucks.Count > 0)
            {
                double trucksAvrHp = Trucks.Sum(x => x.HorsePower) / (double)Trucks.Count;
                Console.WriteLine($"Trucks have average horsepower of: {trucksAvrHp:f2}.");
            }
            else
                Console.WriteLine("Trucks have average horsepower of: 0.00.");

        }

        private static void CatalogAddVehicle(List<Vehicle> catalog)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string typeOfVehicle = cmdArgs[0];
                string model = cmdArgs[1];
                int horsePower = int.Parse(cmdArgs[3]);
                string color = cmdArgs[2];

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, horsePower, color);

                catalog.Add(vehicle);
            }
        }

        private static void CatalogPrint(List<Vehicle> catalog)
        {
            string cmd;
            while ((cmd = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = cmd;
                if (catalog.Any(x => x.Model == model))
                {
                    Vehicle temp = catalog.Find(x => x.Model == model);
                    temp.ToSting();
                }
            }
        }
    }
    class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string Color { get; set; }

        public Vehicle(string typeOfVehicle, string model, int horsePower, string color)
        {
            this.TypeOfVehicle = typeOfVehicle;
            this.Model = model;
            this.HorsePower = horsePower;
            this.Color = color;
        }
        public void ToSting()
        {
            Console.WriteLine($"Type: {char.ToUpper(this.TypeOfVehicle[0]) + this.TypeOfVehicle.Substring(1)}");
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Horsepower: {this.HorsePower}");
        }
    }
    
}