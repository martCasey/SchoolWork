using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sphere1");
            Sphere sphere1 = new Sphere(5);
            Console.WriteLine(sphere1.ToString());
            Console.ReadLine();

            Console.WriteLine("Sphere2");
            IHasVolume sphere2 = new Sphere(5);
            Console.WriteLine(sphere2.ToString());
            Console.WriteLine("Volume:" + sphere2.CalculateVolume());
            Console.ReadLine();

            //collection
            Console.WriteLine("Collection");
            List<IHasVolume> collectionOfSphere = new List<IHasVolume>();
            IHasVolume sphereA = new Sphere(2);
            IHasVolume sphereB = new Sphere(4);
            IHasVolume sphereC = new Sphere(6);
            collectionOfSphere.Add(sphereA);
            collectionOfSphere.Add(sphereB);
            collectionOfSphere.Add(sphereC);

            //loop to call methods
            for (int i = 0; i < collectionOfSphere.Count(); i++)
            {
                Console.WriteLine(collectionOfSphere[i].ToString());
                Console.WriteLine("Volume:" + collectionOfSphere[i].CalculateVolume());
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
