using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class TransportNetwork
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public (Vehicle, double) CalculateOptimalRoute(Route route)
        {
            Vehicle optimalVehicle = null;
            double minTime = double.PositiveInfinity;

            foreach (var vehicle in vehicles)
            {
                double time = (route.End - route.Start) / (double)vehicle.Speed;
                if (time < minTime && vehicle.Capacity > 0)
                {
                    optimalVehicle = vehicle;
                    minTime = time;
                }
            }

            if (optimalVehicle != null)
            {
                return (optimalVehicle, minTime);
            }
            else
            {
                return (null, 0);
            }
        }
    }
}
