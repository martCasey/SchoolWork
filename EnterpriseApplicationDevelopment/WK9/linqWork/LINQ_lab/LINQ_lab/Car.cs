using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_lab
{
    class Car
    {
        //properties
        public String Make { get; set; }
        public String Model { get; set; }
        public String Registration { get; set; }
        public Double EngineSize { get; set; }

        //constructor
        public Car(String makeIn, String modelIn, String registrationIn, double engineSizeIn)
        {
            this.Make = makeIn;
            this.Model = modelIn;
            this.Registration = registrationIn;
            this.EngineSize = engineSizeIn;
        }

        //toString
        public override string ToString()
        {
            return "Make: " + this.Make +
                   "\nModel:" + this.Model +
                   "\nRegistration: " + this.Registration +
                   "\nEngine Size: " + this.EngineSize +
                   "\n";
        }
    }
}
