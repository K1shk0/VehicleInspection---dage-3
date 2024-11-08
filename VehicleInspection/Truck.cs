using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    class Truck : Vehicle
    {
        public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection) { }

        public override string InspectionStatus()
        {

            if ((DateTime.Now - ProductionDate).TotalDays > 1 * 365)
            {
                return $"Truck requires inspection";
            }
            return $"Truck does not require inspection";
        }

        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }
    }
}
