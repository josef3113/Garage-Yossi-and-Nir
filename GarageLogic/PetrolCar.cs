using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class PetrolCar : PetrolVehicle
    {
        CarDetails CarDetails;
        const eFuelType k_FuelType = eFuelType.Octan98; // not

        public PetrolCar(string i_ModelName, string i_LicenseNumber)
            : base(i_ModelName, i_LicenseNumber)
        {
            // book fill the constractor with all fields that needed.
            m_MaxFuelTank = 45f;
            m_CurrentFuelTank = 0;
            m_PercentOfEnergy = 0;
            CarDetails = new CarDetails(4, "White");
            m_ListOfWheels = new List<Wheel>(4);

            foreach(Wheel wheel in m_ListOfWheels)
            {
                m_ListOfWheels.Add(new Wheel("Unknown", 0, 32));
            }
            
            m_ListOfWheels.Add(new Wheel("Unknown", 0, 32));
            m_ListOfWheels.Add(new Wheel("Unknown", 0, 32));
            m_ListOfWheels.Add(new Wheel("Unknown", 0, 32));
            m_ListOfWheels.Add(new Wheel("Unknown", 0, 32));
        }

        public override void Refuel(string i_FuelType, float i_FuelAmout)
        {
            throw new NotImplementedException();
        }
    }
}