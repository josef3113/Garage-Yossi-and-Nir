﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class PetrolCar : PetrolVehicle
    {
        public PetrolCar(string i_ModelName,string i_LicenseNumber) 
            : base(i_ModelName, i_LicenseNumber)
        {
            // book fill the constractor with all fields that needed.
        }

        public override float PersentOfEnergy // book n take care of this.
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public override void Refuel(string i_FuelType, float i_FuelAmout)
        {
            throw new NotImplementedException();
        }
    }
}
