using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Core.Interfaces;
using VehiclesExtension.IO.Interfaces;
using VehiclesExtension.Models;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Core
{
    public class Engine : IEngine
    {
        private readonly List<IVehicle> vehicles;
        private IReader reader;
        private IWriter writer;

        public Engine(IWriter writer, IReader reader)
        {
            this.writer = writer;
            this.reader = reader;
            vehicles = new List<IVehicle>();
        }

        public void Run()
        {
            IVehicle car = CreateVehicles();
            IVehicle truck = CreateVehicles();
            IVehicle bus = CreateVehicles();

            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(bus);

            int commandsCount = int.Parse(reader.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                ApplyCommands();
            }

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        private IVehicle CreateVehicles()
        {
            string[] vehicleInput = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string vehicleTypeName = vehicleInput[0];
            double fuelQuantity = double.Parse(vehicleInput[1]);
            double fuelConsumption = double.Parse(vehicleInput[2]);
            double fuelTankCapacity = double.Parse(vehicleInput[3]);

            try
            {
                if (vehicleTypeName == "Car")
                {
                    return new Car(fuelQuantity, fuelConsumption, fuelTankCapacity);
                }
                else if (vehicleTypeName == "Truck")
                {
                    return new Truck(fuelQuantity, fuelConsumption, fuelTankCapacity);
                }
                else if (vehicleTypeName == "Bus")
                {
                    return new Bus(fuelQuantity, fuelConsumption, fuelTankCapacity);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return default;
        }
        private void ApplyCommands()
        {
            string[] commandInput = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string commandTypeName = commandInput[0];
            string vehicleTypeName = commandInput[1];
            double value = double.Parse(commandInput[2]);

            IVehicle vehicle = vehicles.Where(v => v.GetType().Name == vehicleTypeName).FirstOrDefault();

            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            try
            {
                if (commandTypeName == "Drive")
                {
                    vehicle.Drive(value);
                }
                else if (commandTypeName == "DriveEmpty")
                {
                    (vehicle as Bus).DriveEmpty(value);
                }
                else if (commandTypeName == "Refuel")
                {
                    vehicle.Refuel(value);
                }
            }
            catch(ArgumentException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
