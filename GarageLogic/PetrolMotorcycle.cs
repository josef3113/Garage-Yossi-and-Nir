using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    class PetrolMotorcycle : PetrolVehicle
    {
        MotorcycleDetails m_DetailsOfMotorcycle;

        public PetrolMotorcycle(string i_Model, string i_LicenseNumber, eTypeOfLicense i_TypeOfLicense, int i_EngineCapacity)
            : base(i_Model, i_LicenseNumber , eFuelType.Octan96, 6f)
        {
            m_DetailsOfMotorcycle = new MotorcycleDetails(i_TypeOfLicense, i_EngineCapacity);
            this.ListOfWheels = new List<Wheel>(2);
            this.ListOfWheels.Add(new Wheel("YosiWhells", 0, 30));
            this.ListOfWheels.Add(new Wheel("YosiWhells", 0, 30));
           
        }

        public override void Refuel(string i_FuelType, float i_FuelAmout)
        {
            // TODO whit check type of fule
        }

        public MotorcycleDetails DetailsOfMotorcycle
        {
            get
            {
                return m_DetailsOfMotorcycle;
            }

            set
            {
                m_DetailsOfMotorcycle = value;
            }
        }

    }
}
