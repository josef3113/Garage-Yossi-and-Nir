using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class Vehicle
    {
        protected readonly string r_Model;
        protected readonly string r_LicenseNumber;
        protected float m_PercentOfEnergy = 100;
        protected List<Wheel> m_ListOfWheels;

        public Vehicle(string i_Model, string i_LicenseNumber)
        {
            r_Model = i_Model;
            r_LicenseNumber = i_LicenseNumber;
        }

        public float PercentOfEnergy
        {
            get
            {
                return m_PercentOfEnergy;
            }
        }

        public string Model
        {
            get
            {
                return r_Model;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return r_LicenseNumber;
            }
        }

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
