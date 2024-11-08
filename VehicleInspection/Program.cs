namespace VehicleInspection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", "M5", new DateTime(2021, 7, 11), DateTime.Now);
            Truck myTruck = new Truck("Scania", "R450", new DateTime(2022, 11, 5), DateTime.Now);

            Console.WriteLine(myCar.DisplayInfo());
            Console.WriteLine(myCar.InspectionStatus());

            Console.WriteLine(myTruck.DisplayInfo());
            Console.WriteLine(myTruck.InspectionStatus());

            Console.ReadKey(true);
        }
    }
}
