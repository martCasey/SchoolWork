using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces
{
    class Sphere : IHasVolume
    {
        //fields
        int radius;

        //property
        public int Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }

        //constructor
        public Sphere(int radiusIn)
        {
            this.Radius = radiusIn;
        }

        //interface method implementation
        double IHasVolume.CalculateVolume()
        {
            //field
            double pi = 3.14;
            double volume = pi * this.Radius * this.Radius * this.Radius;
            return volume;
        }

        //toString
        public override string ToString()
        {
            return base.ToString() + "\nDetails:" + "\nRadius: " + this.Radius;
        }
    }
}
