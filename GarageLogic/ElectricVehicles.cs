using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class ElectricVehicles :Vehicle
    {
        private float m_BatteryHours;
        private float m_MaxHoursBattery;

        public float BatteryHours
        {
            get
            {
                return m_BatteryHours;
            }

            set
            {
                m_BatteryHours = value;
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

        public void ChargingBattery()
        {
            // book to do with exption
        }

        // book i dont know what is this 
        public override float PersentOfEnergy => throw new NotImplementedException();
    }
}
