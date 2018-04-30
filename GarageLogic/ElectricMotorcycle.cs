using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class ElectricMotorcycle : ElectricVehicles
    {
        const float k_MaxHoursBattery = 1.8f, k_MaxAirPressure = 30;
        const byte k_NumOfWheels = 2;

        private MotorcycleDetails m_DetailsOfMotorcycle;

        public ElectricMotorcycle(string i_Model, string i_LicenseNumber, string i_TypeOfLicense, int i_EngineCapacity)
            : base(i_Model, i_LicenseNumber, k_NumOfWheels, k_MaxHoursBattery)
        {
            m_DetailsOfMotorcycle = new MotorcycleDetails(i_TypeOfLicense, i_EngineCapacity);
            m_BatteryHoursLeft = 0;
            m_PercentOfEnergy = 0;
            initWheelsList("Unknown", 0, k_MaxAirPressure, k_NumOfWheels);
        }

        public string TypeOfLicense
        {
            get
            {
                return m_DetailsOfMotorcycle.TypeOfLicense;
            }

            set
            {
                m_DetailsOfMotorcycle.TypeOfLicense = value;
            }
        }

        public int EngineCapacity
        {
            get
            {
                return m_DetailsOfMotorcycle.EngineCapacity;
            }
        }
    }
}
