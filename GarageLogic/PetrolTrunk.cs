using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class PetrolTrunk : PetrolVehicle
    {
        TruckDetails m_TruckDetails;


        public PetrolTrunk(string i_Model, string i_LicenseNumber) : base(i_Model, i_LicenseNumber)
        {
        }

        public override void Refuel(string i_FuelType, float i_FuelAmout)
        {
            throw new NotImplementedException();
        }
    }
}
