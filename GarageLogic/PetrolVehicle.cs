using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    abstract public class PetrolVehicle : Vehicle
    {
        protected float m_MaxFuelTank, m_CurrentFuelTank;
        
        public PetrolVehicle(string i_Model, string i_LicenseNumber) : base(i_Model, i_LicenseNumber)
        {
        }

        abstract public void Refuel(string i_FuelType, float i_FuelAmout);

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
