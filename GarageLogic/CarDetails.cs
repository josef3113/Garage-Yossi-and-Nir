using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    internal class CarDetails
    {

        private readonly byte m_DoorsCount;
        private eCarColor m_CarColor;

        public CarDetails(byte i_DoorCount, string i_CarColor)
        {
            m_DoorsCount = i_DoorCount;
            m_CarColor = (eCarColor)Enum.Parse(typeof(eCarColor), i_CarColor); // book to check if it work and if it need to be here;
        }

        public byte DoorsCount
        {
            get
            {
                return m_DoorsCount;
            }
        }

        public eCarColor CarColor // book to check how to do it right
        {
            get
            {
                return m_CarColor;
            }

            set
            {
                m_CarColor = value;
            }
        }


        public enum eCarColor : byte
        {
            Gray,
            Blue,
            White,
            Black
        }
    }
}
