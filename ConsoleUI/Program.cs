using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            Console.ReadLine();
        }

        public static void TestingYosi()
        {
           
            
            GarageLogic.Wheel check = new GarageLogic.Wheel("YosiWheel",0,30);
            Console.WriteLine(check);
            check.AirInflation(23);
            Console.WriteLine(check);

            GarageLogic.ElectricMotorcycle motorcycle = new GarageLogic.ElectricMotorcycle("kavasaky", "34-45", GarageLogic.eTypeOfLicense.B1, 560);

            motorcycle.ChargingBattery(3);
            
            Console.ReadLine();
            
        }

    }
}
