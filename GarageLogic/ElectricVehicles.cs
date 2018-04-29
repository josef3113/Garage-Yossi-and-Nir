using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class ElectricVehicles : Vehicle
    {
        private float m_BatteryHoursLeft;
        private float m_MaxHoursBattery;

        protected ElectricVehicles(string i_Model, string i_LicenseNumber)
            : base(i_Model, i_LicenseNumber)
        {
        }

        public float BatteryHoursLeft
        {
            get
            {
                return m_BatteryHoursLeft;
            }

            set
            {
                m_BatteryHoursLeft = value;
            }
        }

        public float MaxHoursBattery
        {
            get
            {
                return m_MaxHoursBattery;
            }

            set
            {
                m_MaxHoursBattery = value;
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
