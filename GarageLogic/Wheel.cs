﻿using System;
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

        public Wheel(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            this.ManufacturerName = i_ManufacturerName;
            this.CurrentAirPressure = i_CurrentAirPressure;
            this.MaxAirPressure = i_MaxAirPressure;
        }

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

        public float CurrentAirPressure
        {
            get
            {
                return m_CurrentAirPressure;
            }
            // book need to check if is more than max Air Pressure..........
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

            private set
            {
                m_MaxAirPressure = value;
            }
        }

        public void AirInflation(float i_AmountOfAirToAdd)
        {
            if((m_CurrentAirPressure + i_AmountOfAirToAdd) <= m_MaxAirPressure )
            {
                m_CurrentAirPressure += i_AmountOfAirToAdd;
            }
            else
            {                                       // it is max that you can insert in your "tank"
                throw new ValueOutOfRangeException(null,  m_MaxAirPressure - m_CurrentAirPressure, 0);
            }
        }

        public override string ToString()
        {
            return string.Format(
@"Deatels of Whell :
The  ManufacturerName  is :{0}
The MaxAirPressure     is :{1}
The CurrentAirPressure is :{2}"
, ManufacturerName, MaxAirPressure, CurrentAirPressure);
        }
    }
}
