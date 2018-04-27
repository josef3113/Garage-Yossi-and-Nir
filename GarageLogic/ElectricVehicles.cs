using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class ElectricVehicles :Vehicle
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

        public void ChargingBattery(float i_AmoutOfEnergyToAdd)
        {
            if( (m_BatteryHours + i_AmoutOfEnergyToAdd) <= m_MaxHoursBattery  )
            {
                m_BatteryHours += i_AmoutOfEnergyToAdd;
            }
            else
            {
                // book need to br exption
            }

        }
        

        // book i dont know what is this 
        public override float PersentOfEnergy => throw new NotImplementedException();
    }
}
