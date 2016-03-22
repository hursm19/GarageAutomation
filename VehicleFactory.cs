using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public enum VehicleType
    {
        CAR,
        TRUCK,
        SUV,
        MOTORCYCLE
    }
    class VehicleFactory
    {
        public Vehicle createVehicle(VehicleType vehicle)
        {
            if (vehicle == VehicleType.CAR)
            {
                return new Car();
            }
            else if (vehicle == VehicleType.TRUCK)
            {
                return new Truck();
            }
            else if (vehicle == VehicleType.SUV)
            {
                return new SUV();
            }
            else if (vehicle == VehicleType.MOTORCYCLE)
            {
                return new Motorcycle();
            }

            return null;
        }

    }
}
