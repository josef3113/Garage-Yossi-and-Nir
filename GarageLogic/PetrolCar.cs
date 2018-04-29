using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class PetrolCar : PetrolVehicle
    {
        CarDetails CarDetails;

        public PetrolCar(string i_ModelName,string i_LicenseNumber) 
            : base(i_ModelName, i_LicenseNumber)
        {
            // book fill the constractor with all fields that needed.
            CarDetails = new CarDetails(4,"White");
        }

        public override float PersentOfEnergy => throw new NotImplementedException();

        public override void SetPersentOfEnergy(float value)
        {
            throw new NotImplementedException();
        }

        public override void Refuel(string i_FuelType, float i_FuelAmout)
        {
            throw new NotImplementedException();
        }
    }
}