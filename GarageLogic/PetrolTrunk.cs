using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class PetrolTrunk : PetrolVehicle
    {
        const float k_MaxFuelTank = 6f, k_MaxAirPressure = 28;
        const byte k_NumOfWheels = 12;
        TruckDetails m_TruckDetails;

        public PetrolTrunk(string i_Model, string i_LicenseNumber,float i_TrunkCapacity, bool i_IsHaveCoolTank = false) 
            : base(i_Model, i_LicenseNumber ,eFuelType.Soler,k_MaxFuelTank, k_NumOfWheels)
        {
            m_CurrentFuelTank = 0;
            m_PercentOfEnergy = 0;
            m_TruckDetails = new TruckDetails(i_IsHaveCoolTank,i_TrunkCapacity);
            initWheelsList("Unknown", 0, k_MaxAirPressure, k_NumOfWheels);
        }

        public bool IsHaveCoolTank
        {
            get
            {
                return m_TruckDetails.HaveCoolTrunk;
            }
            set
            {
                m_TruckDetails.HaveCoolTrunk = value;
            }
        }

        public float TruckDetails
        {
            get
            {
                return m_TruckDetails.TrunkCapacity;
            }
            set
            {
                m_TruckDetails.TrunkCapacity = value;
            }
        }
    }
}
