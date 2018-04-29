using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public abstract class Vehicle
    {
        protected readonly string m_Model;      // r_Model
        protected readonly string m_LicenseNumber; // r_LicenseNumber
        protected float m_PersentOfEnergy = 100;
        protected List<Wheel> m_ListOfWheels;

        public Vehicle(string i_Model ,string i_LicenseNumber)
        {
            m_Model = i_Model;
            m_LicenseNumber = i_LicenseNumber;
        }       

        public string Model
        {
            get
            {
                return m_Model;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
        }
        
        abstract public float PersentOfEnergy
        {
        // book to do when we can , precent of energy.
            get;
            set;
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
