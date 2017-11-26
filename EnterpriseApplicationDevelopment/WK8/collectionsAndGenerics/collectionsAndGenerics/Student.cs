using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsAndGenerics
{
    class Student
    {
        public string StudentID { get; set; }                   //properties
        public string Name { get; set; }
        public string Gender { get; set; }

        public Student(string studentIDIn, string nameIn, string genderIN)                    //Constructor
        {
            this.StudentID = studentIDIn;
            this.Name = nameIn;
            this.Gender = genderIN;
        }

        public string toString()                    //toString
        {
            return "Student ID: " + this.StudentID +
                    "\nName: " + this.Name +
                    "\nGender: " + this.Gender;
        }

    }
}
