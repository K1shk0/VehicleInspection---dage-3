using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    abstract class Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection {  get; set; }

        public Vehicle(string brand, string model, DateTime productionDate, DateTime lastInspection)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            LastInspection = lastInspection;
        }

        public abstract string InspectionStatus();

        public virtual string DisplayInfo()
        {
            return $"{Brand}, {Model}, Production Date: {ProductionDate.ToShortDateString()}";
        }
    }
}
