using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    internal class MotorcycleDetails
    {
        const int k_MaxOfEngineCapacity = 7_000;
        private int m_EngineCapacity;
        private eTypeOfLicense m_TypeOfLicense;

        public MotorcycleDetails(string i_TypeOfLicense, int i_EngineCapacity)
        {
            TypeOfLicense = i_TypeOfLicense;
            EngineCapacity = i_EngineCapacity;
        }

        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }

            set
            { 
                if(value >= 0 && value <= k_MaxOfEngineCapacity)
                {
                    m_EngineCapacity = value;
                }
                else
                {
                    throw new ValueOutOfRangeException(null, k_MaxOfEngineCapacity, 0);
                }

                
            }
        }

        public string TypeOfLicense
        {
            get
            {
                return m_TypeOfLicense.ToString();
            }

            set
            {
                if (Enum.TryParse<eTypeOfLicense>(value, out eTypeOfLicense someTypeLicense))
                {
                    m_TypeOfLicense = someTypeLicense;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

        // book i not sure about all use in enum check this 
        public enum eTypeOfLicense : byte
        {
            A = 1,
            A1,
            B1,
            B2
        }
    } 
    
}
