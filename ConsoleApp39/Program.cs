using ConsoleApp39;

class Program
{
    static void Main()
    {
        
        var cars = new ExampleClass[3]; 
        for (int i = 0; i < 3;i++)
        {
            
            var carModel = Console.ReadLine();
            var carColor = Console.ReadLine();
            var carOwner = Console.ReadLine();
            cars[i] = new ExampleClass(carModel, carColor, carOwner);
        }
             
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.CarModel},  {car.CarColor}  -  {car.OwnerName}");
        }

    }


}

