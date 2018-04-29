using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    abstract public class PetrolVehicle : Vehicle
    {
        protected readonly float m_MaxFuelTank;  
        protected float m_CurrentFuelTank;
        protected readonly eFuelType r_FuelType;

        public PetrolVehicle(string i_Model, string i_LicenseNumber, eFuelType i_FuelType,float i_MaxFuelTank,byte i_NumOfWheels) 
            : base(i_Model, i_LicenseNumber, i_NumOfWheels)
        {
            r_FuelType = i_FuelType;
            m_MaxFuelTank = i_MaxFuelTank;
        }
                
        public void Refuel(string i_FuelType, float i_FuelAmout)
        {
            if (Enum.TryParse<eFuelType>(i_FuelType, out eFuelType currentFuel))
            {
                if (currentFuel == r_FuelType)
                {
                    if (m_CurrentFuelTank + i_FuelAmout <= m_MaxFuelTank)
                    {
                        m_CurrentFuelTank += i_FuelAmout;
                        m_PercentOfEnergy = m_CurrentFuelTank / m_MaxFuelTank;
                    }
                    else
                    {
                        throw new ValueOutOfRangeException(null, m_MaxFuelTank - m_CurrentFuelTank, 0);
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new FormatException();
            }
        }

        public float MaxFuelTank
        {
            get
            {
                return m_MaxFuelTank;
            }
        }
        
        public float CurrentFuelTank
        {
            get
            {
                return m_CurrentFuelTank;
            }
        }

        public enum eFuelType : byte
        {
            Soler ,
            Octan95 ,
            Octan96 ,
            Octan98
        }    
    }
}
