namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
                car1.Brand = "Toyota";
                car1.Model = "Corolla";
                car1.Year = 2020;
                car1.Mileage = 15000;
                car1.Drive(100);
                car1.ShowCarInfo();

            Car car2 = new Car();
                car2.Brand = "Tesla";
                car2.Model = "Sedan";
                car2.Year = 2025;
                car2.Mileage = 5000;
                car2.Drive(5000);
                car2.ShowCarInfo();


        }
    }
}
