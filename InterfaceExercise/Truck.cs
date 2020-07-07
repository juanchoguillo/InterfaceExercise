using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public int CountTires { get; set; }
        public int CountDoors { get; set; }
        public string EngineNoise()
        {
            return " Crunh Cruch";
        }

        public string CompanyName { get; set; }
        public int FoundationYear { get; set; }

        public DateTime ExactlyTimeWasBougth()
        {
            return new DateTime(2015, 06, 30);
        }

        public int WeigthCapacity { get; set; }
        public string CountSeat(int countSeat)
        {
            return $" this car has {countSeat} doors";
        }
    }
}
