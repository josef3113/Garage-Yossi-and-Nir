using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class ElectricVehicles : Vehicle
    {
        protected float m_BatteryHoursLeft;
        protected readonly float m_MaxHoursBattery;

        protected ElectricVehicles(string i_Model, string i_LicenseNumber, byte i_NumOfWheels, float i_MaxHoursBattery)
            : base(i_Model, i_LicenseNumber, i_NumOfWheels)
        {
            m_MaxHoursBattery = i_MaxHoursBattery;
        }

        public float BatteryHoursLeft
        {
            get
            {
                return m_BatteryHoursLeft;
            }
        }

        public float MaxHoursBattery
        {
            get
            {
                return m_MaxHoursBattery;
            }

        }

        public void ChargingBattery(float i_AmoutOfEnergyToAdd)
        {
            if((m_BatteryHoursLeft + i_AmoutOfEnergyToAdd) <= m_MaxHoursBattery)
            {
                m_BatteryHoursLeft += i_AmoutOfEnergyToAdd;
                m_PercentOfEnergy = m_BatteryHoursLeft / m_MaxHoursBattery;
            }
            else
            {
                throw new ValueOutOfRangeException(null, m_MaxHoursBattery - m_BatteryHoursLeft, 0);
            }
        }
    }
}
