using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class MotorcycleDetails
    {
        private int m_EngineCapacity;
        private eTypeOfLicense m_TypeOfLicense = eTypeOfLicense.A; // difult is A

        public MotorcycleDetails(eTypeOfLicense i_TypeOfLicense, int i_EngineCapacity)
        {
            this.TypeOfLicense = i_TypeOfLicense;
            this.EngineCapacity = i_EngineCapacity;
        }

        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }

            set
            {
                m_EngineCapacity = value;
            }
        }

        public eTypeOfLicense TypeOfLicense
        {
            get
            {
                return m_TypeOfLicense;
            }

            set
            {
                m_TypeOfLicense = value;
            }
        }
    } // nasted
    // book i not sure about all use in enum check this 
    public enum eTypeOfLicense : byte
    {
        A = 1,
        A1,
        B1,
        B2
    }
}
