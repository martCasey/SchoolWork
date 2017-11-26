using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> fleet = new List<Car>();          //collection of car objects
            fleet.Add(new Car() { Make = "Mazda", Model = "MX5", Registration = "12 D 12", EngineSize = 2000 });
            fleet.Add(new Car() { Make = "Mazda", Model = "3", Registration = "12 D 13", EngineSize = 1600 });
            fleet.Add(new Car() { Make = "BMW", Model = "5 Series", Registration = "12 D 14", EngineSize = 2000 });
            fleet.Add(new Car() { Make = "Toyota", Model = "Yaris", Registration = "12 D 16", EngineSize = 1100 });
            fleet.Add(new Car() { Make = "Renault", Model = "Scenic", Registration = "12 D 17", EngineSize = 1400 });
            fleet.Add(new Car() { Make = "Ford", Model = "Focus", Registration = "12 D 15", EngineSize = 1400 });

            //run quries

            var allCars = fleet.OrderBy(car => car.Registration);           //List all cars in registration order
            Console.WriteLine("All cars in ascending registration order");
            foreach(var car in allCars)
            {
                Console.WriteLine(car);
                Console.WriteLine();
            }

            var mazdaCars = fleet.Where(car => car.Make == "Mazda").Select(car => car.Model);           //list the models for all Mazda cars in the fleet
            Console.WriteLine("All Mazda cars in the fleet");
            foreach (var car in mazdaCars)
            {
                Console.WriteLine(car);
                Console.WriteLine();
            }

            var descendingSize = fleet.OrderByDescending(car => car.EngineSize);            //list all cars in descending engine size order
            Console.WriteLine("All cars in descending engine size order");
            foreach (var car in descendingSize)
            {
                Console.WriteLine(car);
                Console.WriteLine();
            }

            var makesandmodels = fleet.Select(car => new { car.Make, car.Model });          //list just the make and model for cars whose engines size is 1600 cc.
            Console.WriteLine("The make and models of all cars whose engine size is 16000 cc");
            foreach (var car in makesandmodels)
            {
                Console.WriteLine(car.Make + " " + car.Model);
                Console.WriteLine();
            }

            var count = fleet.Where(car => car.EngineSize <= 1600).Count();         //count the number of cars whose engine size is 1600 cc or less
            Console.WriteLine("The number of cars whose engine size is 1600 cc or less");
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
