using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
    public class Car : ICompany, IVehicle
    {
        public Car()
        {
        }

        public int CountTires { get; set; }
        public int CountDoors { get; set; }
        public string CompanyName { get; set; }
        public int FoundationYear { get; set; }

        public string EngineNoise() 
        {
            return "Brum Brum";
        }

        public DateTime ExactlyTimeWasBougth()
        {
            return new DateTime(2012, 12, 25) ;
        }

        public string MeanColor { get; set; }

        public string CountDoor(int countDoors)
        {
            return $" this car has {countDoors} doors";
        }
    }
}
