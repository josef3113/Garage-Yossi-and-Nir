using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    internal class CarDetails
    {
        private byte m_DoorsCount;
        private eCarColor m_CarColor;

        public CarDetails(byte i_DoorCount, string i_CarColor)
        {
            DoorsCount = i_DoorCount;
            CarColor = i_CarColor;
        }

        public byte DoorsCount
        {
            get
            {
                return m_DoorsCount;
            }

            protected set
            {
                if (value >= 2 && value <= 5)
                {
                    m_DoorsCount = value;
                }
                else
                {
                    throw new ValueOutOfRangeException(null, 5, 2);
                }
            }
        }

        public string CarColor
        {
            get
            {
                return m_CarColor.ToString();
            }

            set
            {
                if (Enum.TryParse<eCarColor>(value, out eCarColor someColor))
                {
                    m_CarColor = someColor;
                }
                else
                {
                    throw new FormatException();
                }
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
