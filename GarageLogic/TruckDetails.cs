using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    internal class TruckDetails
    {
        const float k_MaxCapacityTank = 60_000f;
        private bool m_HaveCoolTrunk;
        private float m_TrunkCapacity;

        public TruckDetails(bool i_HaveCoolTrunk, float i_TrunkCapacity)
        {
            m_HaveCoolTrunk = i_HaveCoolTrunk;
            m_TrunkCapacity = i_TrunkCapacity;
        }

        public bool HaveCoolTrunk
        {
            get
            {
                return m_HaveCoolTrunk;
            }

            set
            {
                m_HaveCoolTrunk = value;
            }
        }

        public float TrunkCapacity
        {
            get
            {
                return m_TrunkCapacity;
            }

            set
            {
                if (value >= 0 && value <= k_MaxCapacityTank)
                {
                    m_TrunkCapacity = value;
                }
                else
                {
                    throw new ValueOutOfRangeException(null, k_MaxCapacityTank, 0);
                }
            }
        }
    }
}
