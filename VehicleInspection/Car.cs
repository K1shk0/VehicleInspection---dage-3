using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    class Car : Vehicle
    {
        public Car(string brand, string model, DateTime produtionDate, DateTime lastInspection)
            : base(brand, model, produtionDate, lastInspection) { }

        public override string InspectionStatus()
        {
            if ((DateTime.Now - ProductionDate).TotalDays > 4 * 365)
                return "Car requires inspection";
            return "Car does not require inspection";
        }

        public override string DisplayInfo()
        {
            return $"Car: {Brand} {Model}";
        }
    }
}
