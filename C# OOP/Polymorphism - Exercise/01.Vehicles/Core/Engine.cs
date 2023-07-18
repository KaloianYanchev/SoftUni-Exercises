using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
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

            vehicles.Add(car);
            vehicles.Add(truck);

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

            if (vehicleTypeName == "Car")
            {
                return new Car (fuelQuantity, fuelConsumption);
            }
            else if (vehicleTypeName == "Truck")
            {
                return new Truck(fuelQuantity, fuelConsumption);
            }
            else
            {
                throw new Exception();
            }
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
            
            if (commandTypeName == "Drive")
            {
                vehicle.Drive(value);
            }
            else if (commandTypeName == "Refuel")
            {
                vehicle.Refuel(value);
            }
        }
    }
}
