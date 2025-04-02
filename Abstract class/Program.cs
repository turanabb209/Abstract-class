namespace Abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new();
            Bicycle bicycle = new();

            car.FactoryName = "Toyota";
            car.Model = "Corolla";
            car.Color = "Black";
            car.DriveTime = 5;
            car.DrivePath = 340;
            car.DoorCount = 4;
            car.IsElctricCar = false;
            car.GetInfo();
            car.DefineNatureHarmness();
            car.ToString();

            Console.WriteLine("--------------------------------------------------");
            bicycle.FactoryName = "Giant";
            bicycle.Model = "Escape2";
            bicycle.Color = "White";
            bicycle.DriveTime = 2;
            bicycle.DrivePath = 50;
            bicycle.Type = "Road";
            bicycle.GetInfo();
            bicycle.DefineNatureHarmness();
            bicycle.ToString();
    } 
}
}
