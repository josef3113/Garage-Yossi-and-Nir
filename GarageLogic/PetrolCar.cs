using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class PetrolCar : PetrolVehicle
    {
        const byte k_NumOfWheels = 4;
        const float k_MaxAirPressure = 32, k_CurrentFuelTank = 45f;
        private CarDetails m_CarDetails;

        public PetrolCar(string i_ModelName, string i_LicenseNumber, string i_CarColor)
            : base(i_ModelName, i_LicenseNumber, eFuelType.Octan98, k_CurrentFuelTank, k_NumOfWheels)
        {
            // book fill the constractor with all fields that needed.            
            m_CurrentFuelTank = 0;
            m_PercentOfEnergy = 0;
            m_CarDetails = new CarDetails(4, i_CarColor);
            initWheelsList("Unknown", 0, k_MaxAirPressure, k_NumOfWheels);
        }

        public string CarColor
        {
            get
            {
                return m_CarDetails.CarColor;
            }
            set
            {
                m_CarDetails.CarColor = value;
            }
        }

        public byte DoorsCount
        {
            get
            {
                return m_CarDetails.DoorsCount;
            }
        }
    }
}