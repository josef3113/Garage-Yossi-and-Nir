using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class PetrolMotorcycle : PetrolVehicle
    {
        const float k_MaxAirPressure = 30, k_MaxFuelTank = 6f;
        const byte k_NumOfWheels = 2;
        MotorcycleDetails m_DetailsOfMotorcycle;

        public PetrolMotorcycle(string i_Model, string i_LicenseNumber, string i_TypeOfLicense, int i_EngineCapacity)
            : base(i_Model, i_LicenseNumber , eFuelType.Octan96, k_MaxFuelTank, k_NumOfWheels)
        {
            m_DetailsOfMotorcycle = new MotorcycleDetails(i_TypeOfLicense, i_EngineCapacity);
            m_CurrentFuelTank = 0;
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
