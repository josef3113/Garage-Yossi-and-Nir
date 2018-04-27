using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue;
        private float m_MinValue;

        public float MaxValue
        {
            get
            {
                return m_MaxValue;
            }

            set
            {
                 m_MaxValue = value;
            }
        }

        public float MinValue
        {
            get
            {
                return m_MinValue;
            }

            set
            {
                m_MinValue = value;
            }
        }

        public ValueOutOfRangeException(
            Exception i_innerException,
            float i_MaxValue,
            float i_MinValue)
            :base(
                 "The value was outside from rang",
                 i_innerException)
        {
            MaxValue = i_MaxValue;
            MinValue = i_MinValue;
        }
    }
}
