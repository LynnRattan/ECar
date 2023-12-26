namespace ElectricCar
{
    internal class Program
    {
        //static List<TaskExecutor> tasks = new List<TaskExecutor>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ElectricCar eCar = new ElectricCar(1);
            eCar.StartEngine();

            ElectricCar [] cars = new ElectricCar[20];
            for (int i = 0; i < 20; i++) 
            {
                cars[i]= new ElectricCar(i+1);
            }
            for (int i = 0; i < 20; i++)
            {
                Thread engineThread = new Thread(cars[i].StartEngine);
                engineThread.Start();
            }
           
        }
    }
}