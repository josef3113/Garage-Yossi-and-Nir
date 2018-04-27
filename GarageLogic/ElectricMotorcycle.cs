using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageLogic
{
    public class ElectricMotorcycle : ElectricVehicles
    {
        private MotorcycleDetails m_DetailsOfMotorcycle;

        public ElectricMotorcycle(int i_NumOfWheels)
        {
            this.ListOfWheels = new List<Wheel>(2);
            this.ListOfWheels.Add(new Wheel());
            this.ListOfWheels.Add(new Wheel());
        }
    }
}
