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
            GarageLogic.ElectricMotorcycle stam = new GarageLogic.ElectricMotorcycle(2);
            List<GarageLogic.Wheel> test = stam.ListOfWheels;

            Console.WriteLine(test.Count);
            GarageLogic.Wheel check = new GarageLogic.Wheel();
            check.MaxAirPressure = 20;
            check.CurrentAirPressure = 3;
            try
            {
                check.AirInflation(21); 
            }
            catch(GarageLogic.ValueOutOfRangeException vore )
            {
                Console.WriteLine(vore.Message);

            }
            
            Console.ReadLine();
            
        }

    }
}
