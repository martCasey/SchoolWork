using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_ClassesAndProperties
{
    class Program
    {//Main is the test program
        static void Main(string[] args)
        {
            //ThreeDShapes shape1;
            ThreeDShapes shape2;
            shape2 = new Sphere("sphere", 18);
            shape2.ToString();
            Console.WriteLine(shape2.ToString());
            Console.ReadLine();
        }
    }
    //first part of lab
    public abstract class ThreeDShapes
    {
        //fields
        //readonly string shapeType;

        //properties
        public string ShapeType { get; set; }

        //methods
        public ThreeDShapes(string shapeTypeIn)
        {
            ShapeType = shapeTypeIn;
        }

        public abstract void calculateVolume();

        public override string ToString()
        {
            return "Shape Details";
        }
    }

        //second part of lab
        public class Sphere : ThreeDShapes
        {

        //fields
        //double radius;

        //properties
        public double Radius { get; set; }

            public Sphere(string shapeTypeIn, double radiusIn)
                :base(shapeTypeIn)
            {
            Radius = radiusIn;
            }

            public override void calculateVolume()
            {
                double pi = 3.14;
                double volume;
                volume = pi * Radius * Radius * Radius;
                throw new NotImplementedException();
            }

        public override string ToString()
        {
            return base.ToString() + "\nType: Sphere" + " Radius: " + Radius;

        }
    }
}