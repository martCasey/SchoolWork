using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //fleet collection of cars
            //trying to work on Linq components
            List<Car> fleet = new List<Car>();

            //populate fleet with some cars
            Car car1 = new Car("Honda", "V2", "REG123", 4.5);
            Car car2 = new Car("Santafey", "RT6", "REG456", 2.3);
            Car car3 = new Car("Opal", "CX22", "REG789", 3.3);
            Car car4 = new Car("VolskWagen", "VO90", "REG101112", 4.1);
            fleet.Add(car1);
            fleet.Add(car2);
            fleet.Add(car3);
            fleet.Add(car4);

            //list all cars in ascending registration order
            var regAscend = (from reg in fleet
                             where reg != null
                             select reg).OrderBy;

            //foreach loop
            foreach(regAscend in fleet)
            {
                Console.WriteLine(regAscend.ToString());
            }
            Console.ReadLine();
        }
    }
}
