using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class Vehicle
    {
        private string m_Model;
        private string m_LicenseNumber;
        private float m_PersentOfEnergy;
        List<Wheel> m_ListOfWheels;

        public string Model
        {
            get
            {
                return m_Model;
            }

            set
            {
                m_Model = value;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }

            set
            {
                m_LicenseNumber = value;
            }
        }
        
        abstract public float PersentOfEnergy
        {
        // book to do when we can , precent of energy.
            get;          
        }

        // book yossi here put the - tire .
        public List<Wheel> ListOfWheels
        {
            get
            {
                return m_ListOfWheels;
            }
            set // book think about this mybe not need or need to be privat
            {
                m_ListOfWheels = value;
            }
        }
    }
}
