using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = new VehicleFactory();

            Vehicle newVehicle = vehicleFactory.createVehicle(VehicleType.CAR);

            newVehicle.parkingLevel = "A";
            Console.WriteLine(newVehicle.parkingLevel);
            Console.WriteLine(newVehicle.getDescription());
            Console.ReadKey();
        }
    }
}
