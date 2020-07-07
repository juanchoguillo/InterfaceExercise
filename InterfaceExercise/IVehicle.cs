using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int CountTires { get; set; }
        public int CountDoors { get; set; }

        public string EngineNoise();

        public DateTime ExactlyTimeWasBougth();
    }
}
