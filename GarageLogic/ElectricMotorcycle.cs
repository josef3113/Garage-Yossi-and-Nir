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

        public ElectricMotorcycle(eTypeOfLicense i_TypeOfLicense, int i_EngineCapacity)
        {
            m_DetailsOfMotorcycle = new MotorcycleDetails(i_TypeOfLicense, i_EngineCapacity);
            this.ListOfWheels = new List<Wheel>(2);
            this.ListOfWheels.Add(new Wheel("YosiWhells",0,30));
            this.ListOfWheels.Add(new Wheel("YosiWhells", 0, 30));
            this.MaxHoursBattery = (float)1.8;
        }
    }
}
