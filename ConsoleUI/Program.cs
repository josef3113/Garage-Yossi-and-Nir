using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageLogic;

namespace ConsoleUI  // add referns to logick for check 
{
    class Program
    {
        public static void Main()
        {

            //Testing();
            TestingYosi();


        }
        
        public static void Testing()
        {
            Console.WriteLine("new Hey");

            Vehicle[] vehicles = new Vehicle[7];

            vehicles[0] = new PetrolCar("Jetta", "34567", "Gray", 4);
            vehicles[1] = new PetrolCar("Ferrari", "87654", "Blue", 2);
            vehicles[2] = new ElectricCar("Tesla", "32451", "White", 4);
            vehicles[3] = new PetrolTrunk("Volvo", "12563", 15_000f,true);
            vehicles[4] = new ElectricCar("Renu", "08912", "Gray",3);
            vehicles[5] = new ElectricMotorcycle("kavasaki", "333333", "B", 500);
            vehicles[6] = new PetrolMotorcycle("kavasaki", "333333", "B", 500);

            PetrolVehicle car = new PetrolCar("Jetta","34567","Gray",4);
            
            Console.ReadLine();
        }

        public static void TestingYosi()
        {
           
            
            GarageLogic.Wheel check = new GarageLogic.Wheel("YosiWheel",0,30);
            Console.WriteLine(check);
            check.AirInflation(23);
            Console.WriteLine(check);

            GarageLogic.ElectricMotorcycle motorcycle = new GarageLogic.ElectricMotorcycle("kavasaky", "34-45", "B", 560);

           
            
            Console.ReadLine();
            
        }

    }
}
