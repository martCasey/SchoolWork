using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Polymorphism
{
    class Program
    {//Test class
        static void Main(string[] args)
        {//how do I test just the vertex
            //objects
            //testing vertex
            Console.WriteLine("Vertex");
            Vertex vert1 = new Vertex(1, 2);
            Console.WriteLine("Details of Vertex \n"
                            + "X Value: " + vert1.XCoordinate + " "
                            + "Y Value: " + vert1.YCoordinate);
            Console.ReadLine();

            //testing shape
            Console.WriteLine("Shape");
            Shape shape1 = new Shape("red");
            Console.WriteLine(shape1.ToString());
            Console.ReadLine();

            //testing line
            Console.WriteLine("Line");
            Line line1 = new Line(5, 7, 9, 11, "blue");
            Console.WriteLine(line1.ToString());
            line1.Translate(vert1);
            Console.WriteLine("After translation");
            Console.WriteLine(line1.ToString());
            Console.ReadLine();
            
            //testing circle
            Console.WriteLine("Circle");
            Circle circle1 = new Circle(5, 7, 3, "yellow");
            Console.WriteLine(circle1.ToString());
            Console.WriteLine("Area of Circle: " + circle1.Area());
            circle1.Translate(vert1);
            Console.WriteLine("After translation");
            Console.WriteLine(circle1.ToString());
            Console.WriteLine("Area of Circle: " + circle1.Area());
            Console.ReadLine();
            
        }
    }

    //Vertex class
    public class Vertex
    {
        //fields
        int xCoordinate;
        int yCoordinate;//both of these combined are the origin of a circle

        //properties
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        //constructor
        public Vertex(int xCoorIn, int yCoorIn)
        {
            XCoordinate = xCoorIn;
            YCoordinate = yCoorIn;
        }
    }

    //Shape class
    public class Shape
    {
        //fields
        string colour;

        //properties
        public string Colour { get; set; }

        //constructor
        public Shape(string colourIn)
        {
            Colour = colourIn;
        }

        //toString
        public override string ToString()
        {
            return "Shape Details " + "\nColour: "+this.Colour;
        }

        //translate
        public virtual void Translate(Vertex vert1)
        {
            //input the amount you want to translate, override this method in a later class
        }
    }

    //Line class
    public class Line : Shape //a line has two verticies
    {
        Vertex vertLine1;
        Vertex vertLine2;

        //constructor
        public Line(int xCoor1In, int xCoor2In, int yCoor1In, int yCoor2In, string colourIn)
            : base(colourIn)
        {
            vertLine1 = new Vertex(xCoor1In, yCoor1In);
            vertLine2 = new Vertex(xCoor2In, yCoor2In);
        }

        //properties
        public Vertex VertLine1
        {
            get
            {
                return vertLine1;
            }
            set
            {
                vertLine1 = value;
            }
        }

        public Vertex VertLine2
        {
            get
            {
                return vertLine2;
            }
            set
            {
                vertLine2 = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()
                    + "\nX1 Value: " + VertLine1.XCoordinate + " X2 Value: " + VertLine2.XCoordinate
                    + " Y1 Value: " + VertLine1.YCoordinate + " Y2 Value: " + VertLine2.YCoordinate;
        }

        public override void Translate(Vertex vert1)
        {
            base.Translate(vert1);
            //we are moving the x and y n number of spaces based on the values of x&y we can add from the vertex
            VertLine1.XCoordinate += vert1.XCoordinate;
            VertLine1.YCoordinate += vert1.YCoordinate;
            VertLine2.XCoordinate += vert1.XCoordinate;
            VertLine2.YCoordinate += vert1.YCoordinate;
        }
    }

    public class Circle : Shape
    {
        //fields
        int radius;
        Vertex origin;

        //properties
        int Radius { get; set; }

        //constructor
        public Circle(int radiusIn, int xCoor1In, int yCoor1In, string colourIn)
            : base(colourIn)
        {
            Radius = radiusIn;
            origin = new Vertex(xCoor1In, yCoor1In);
        }

        public override string ToString()
        {
            return base.ToString()
                    + "\nRadius: " + Radius + "\nOrigin: " + origin.XCoordinate + ", "
                    + origin.YCoordinate;
        }

        public override void Translate(Vertex vert1)
        {
            //origin contains the x and y axis
            origin.XCoordinate += vert1.XCoordinate;
            origin.YCoordinate += vert1.YCoordinate;
        }

        public double Area()
        {
            double area = 3.14 + (this.Radius * 2);
            return area;

        }
    }
}
