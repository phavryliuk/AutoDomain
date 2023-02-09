using System;

namespace AutoService
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string VIN { get; set; }
        public Engine Engine { get; set; }
        public Wheel[] Wheels { get; set; }
    }

    public class Engine
    {
        public int Id { get; set; }
        public int Horsepower { get; set; }
        public int Torque { get; set; }
    }

    public class Wheel
    {
        public int Id { get; set; }
        public int Diameter { get; set; }
        public int Width { get; set; }
        public string Brand { get; set; }
    }

    public class AutoService
    {
        private Vehicle[] vehicles;

        public AutoService(int maxVehicles)
        {
            vehicles = new Vehicle[maxVehicles];
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }

            return false;
        }

        public Vehicle GetVehicle(int id)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.Id == id)
                {
                    return vehicles[i];
                }
            }

            return null;
        }

        public bool UpdateVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.Id == vehicle.Id)
                {
                    vehicles[i] = vehicle;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveVehicle(int id)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i]?.Id == id)
                {
                    vehicles[i] = null;
                    return true;
                }
            }

            return false;
        }
    }
}
