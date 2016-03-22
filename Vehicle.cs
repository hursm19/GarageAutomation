using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Vehicle : IDatabase
    {
        public string firstName { get; set; } //residential owners name - assign guest for general use?
        public string lastName { get; set; }
        public string licensePlate { get; set; }
        public int parkingLocation { get; set; } //specific parking spot on a level
        public string parkingLevel { get; set; } //specific level of the parking ramp

        public abstract void queryDatabase();
        public abstract void addVehicleToDatabase();
        public abstract string getDescription();
    }
}
