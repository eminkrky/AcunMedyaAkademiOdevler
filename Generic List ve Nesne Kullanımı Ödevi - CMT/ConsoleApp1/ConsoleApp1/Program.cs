class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>
        {
            new Car
            {
                Marka = "Toyota",
                Model = "Corolla",
                FuelConsumption = 6.5,
                TotalDistance = 5000 
            },
            new Car
            {
                Marka = "BMW",
                Model = "X5",
                FuelConsumption = 9.0,
                TotalDistance = 5000
            },
            new Car
            {
                Marka = "Mercedes",
                Model = "C200",
                FuelConsumption = 8.2,
                TotalDistance = 5000
            }
        };

        foreach (Car car in cars)
        {
            car.DisplayInfo();
        }

    }
}