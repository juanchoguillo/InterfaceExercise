using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany 
    {
        public Suv()
        {
        }

        public int CountTires { get; set; }
        public int CountDoors { get; set; }
        public string CompanyName { get; set; }
        public int FoundationYear { get; set; }

        public string EngineNoise()
        {
            return "Trukm Trukm";
        }
        public DateTime ExactlyTimeWasBougth()
        {
            return new DateTime(2000, 10, 25);
        }

        public bool HasBabySeat { get; set; }
        public string PassangersCapacity(int passangersCapacity)
        {
            return $" this car has {passangersCapacity} doors";
        }
    }

       
    
}
