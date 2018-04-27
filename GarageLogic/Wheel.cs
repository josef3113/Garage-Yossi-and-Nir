using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        private float m_CurrentAirPressure;
        private float m_MaxAirPressure;

        public string ManufacturerName
        {
            get
            {
                return m_ManufacturerName;
            }

            set
            {
                m_ManufacturerName = value;
            }
        }

        public float AirPressure
        {
            get
            {
                return m_CurrentAirPressure;
            }

            set
            {
                m_CurrentAirPressure = value;
            }
        }

        public float MaxAirPressure
        {
            get
            {
                return m_MaxAirPressure;
            }

            set
            {
                m_MaxAirPressure = value;
            }
        }

        public void AirInflation(float i_AmountOfAirToAdd)
        {
            if( (m_CurrentAirPressure + i_AmountOfAirToAdd) < m_MaxAirPressure)
            {
                m_CurrentAirPressure += i_AmountOfAirToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(null, m_MaxAirPressure, 0);
            }
        }
    }
}
