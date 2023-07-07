using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Car subaru = new Car
            {
                CuteBeepSound = "beep",
                AllWheelDrivable = true,
                HasWheels = true,
                HasFrame = true,
                IsDriveable = false,
                Exists = false,
                Logo = "set of 4 stars on a blue background",
                Name = "Subaru"
            };
            SUV imprezza = new SUV
            {
                CargoHoldSize = 35,
                HasSpareOnRear = true,
                HasWheels = true,
                HasFrame = true,
                IsDriveable = true,
                Exists = true,
                Logo = "set of 4 stars on a blue background",
                Name = "Subaru"
            };
            Truck margo = new Truck
            {
                HighHorsePower = true,
                HasRearCover = true,
                HasWheels = true,
                HasFrame = true,
                IsDriveable = false,
                Exists = false,
                Logo = "Ram Head",
                Name = "dodge"
            };
            
            List<IVehicle> carLot = new List<IVehicle>() { margo, imprezza, subaru };
            foreach (var vehicle in carLot)
            {
                Console.WriteLine("===========================");
                Console.WriteLine($"This {vehicle.Name} automobile sports a logo that is beset with a {vehicle.Logo}.");
                Console.WriteLine("This vehicle currently " + (vehicle.Exists ? "exists!" : "is theoretical."));
                if (vehicle.GetType() == typeof(Truck))
                {
                    Console.WriteLine(PurchasePhrase(vehicle.Exists) + "this high horsepower truck for just 99,999.99$.");
                }
                else if (vehicle.GetType() == typeof(Car))
                {
                    Console.WriteLine(PurchasePhrase(vehicle.Exists) + "this sleek car today, for just 19,999.99$!");
                }
                else
                {
                    Console.WriteLine(PurchasePhrase(vehicle.Exists) + "this useful SUV for just 29,999.99$!");
                }
            }
        }

        static string PurchasePhrase(bool existance) => existance ? "Buy " : "Pre-purchase ";
    }
}
