namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.ConstrainedExecution;

    class Program
    {
        static void Main()
        {
            Catalog catalog = new Catalog();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split("/");
                string typeOfVehicle = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                int horsePowerOrWeght = int.Parse(cmdArgs[3]);
                if (typeOfVehicle == "Car")
                {

                    Car car = new Car(brand, model, horsePowerOrWeght);
                    catalog.Cars.Add(car);
                }
                else if (typeOfVehicle == "Truck")
                {
                    Truck truck = new Truck(brand, model, horsePowerOrWeght);
                    catalog.Trucks.Add(truck);
                }
            }

            if (catalog.Cars.Count > 0)
            {

                Console.WriteLine("Cars:");
            }
            foreach (var car in catalog.Cars.OrderBy(x => x.CarBrand))
            {
                Console.WriteLine($"{car.CarBrand}: {car.CarModel} - {car.CarHorsePower}hp");
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }
            foreach (var truck in catalog.Trucks.OrderBy(x => x.TruckBrand))
            {
                Console.WriteLine($"{truck.TruckBrand}: {truck.TruckModel} - {truck.TruckWeight}kg");
            }
        }
    }
    class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
    class Car
    {
        public Car(string carBrand, string carModel, int carHorsePower)
        {
            this.CarBrand = carBrand;
            this.CarModel = carModel;
            this.CarHorsePower = carHorsePower;
        }

        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarHorsePower { get; set; }

    }
    class Truck
    {
        public Truck(string truckBrand, string truckModel, int truckWeight)
        {
            this.TruckBrand = truckBrand;
            this.TruckModel = truckModel;
            this.TruckWeight = truckWeight;
        }

        public string TruckBrand { get; set; }
        public string TruckModel { get; set; }
        public int TruckWeight { get; set; }
    }



}