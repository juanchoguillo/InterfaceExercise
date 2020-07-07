using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {




            var myCar = new Car() {CountTires = 4, CompanyName = "Ford", CountDoors = 5, FoundationYear = 1903, MeanColor = "BlueNAvy",  };
            var mySuv = new Suv() { CountTires = 4, CompanyName = "Toyota", FoundationYear = 1937, CountDoors = 5, HasBabySeat = false };
            var myTruck = new Truck() { CountTires = 16, CompanyName = "Honda", FoundationYear = 1948, CountDoors = 2, WeigthCapacity = 500};

            var vehiclesForSale = new List<IVehicle> { myCar, mySuv, myTruck };

            foreach(var vehicle in vehiclesForSale)
            {
                Console.WriteLine($"This is with {vehicle.CountDoors} doors and was bought at  {vehicle.ExactlyTimeWasBougth()}");
            }

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
