using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class ElectricCar : ElectricVehicles
    {
        const float k_MaxHoursBattery = 3.2f, k_MaxAirPressure = 32;
        const byte k_NumOfWheels = 4;
        private CarDetails m_CarDetails;

        public ElectricCar(string i_Model, string i_LicenseNumber, string i_CarColor, byte i_NumOfDoors)
            : base(i_Model, i_LicenseNumber, k_NumOfWheels, k_MaxHoursBattery)
        {
            m_BatteryHoursLeft = 0;
            m_PercentOfEnergy = 0;
            m_CarDetails = new CarDetails(i_NumOfDoors, i_CarColor);
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
