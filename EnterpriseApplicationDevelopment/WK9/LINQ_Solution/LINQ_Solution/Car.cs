using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Solution
{
    class Car       //a simple Car class
    {
        public String Make { get; set; }            //properties
        public String Model { get; set; }
        public String Registration { get; set; }
        public int EngineSize { get; set; }

        public override string ToString()
        {
            return "Make: " + this.Make +
                   "\nModel: " + this.Model +
                   "\nRegistration: " + this.Registration +
                   "\nEngine Size: " + this.EngineSize +
                   "\n";
        }
    }
}
