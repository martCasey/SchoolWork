using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsSolution
{
    public enum Sex { Male, Female }        //enum for gender

    //a student
    public class Student
    {
        public String Id { get; set; }      //unique
        public String Name { get; set; }
        public Sex Gender { get; set; }

        //1 constructor only
        public Student(String id, String name, Sex gender)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Gender: " + Gender;
        }
    }

    //a student class
    public class StudentClass : IEnumerable
    {
        public String Crn { get; set; }         //unique class reference number
        public String Lecturer { get; set; }    //auto-implemented fields

        //collection of students in the class
        private List<Student> students;         //strongly typed

        //1 constructor only
        public StudentClass(String crn, String lecturer)
        {
            this.Crn = crn;
            this.Lecturer = lecturer;

            this.students = new List<Student>();
        }

        //add a student to the class, if not already in the class
        public void AddStudent(Student student)
        {
            if (this.students == null)      //checks if collections has been initialised
            {
                students.Add(student);
            }
            else
            {
                if ((students.Count(s => s.Id == student.Id)) == 1)         //the value s is returning a true value, which is being turned into a count of 1
                {           //the if statement is checking if the student already exists in the collection
                    throw new ArgumentException("Error student " + student.Name + " is already in the class");
                }
                else
                {
                    students.Add(student);
                }
            }
        }

        //indexer based on an int
        public Student this[int i]
        {
            get
            {
                //validate index values
                if ((i >= 0) & (i < students.Count))        //the indexer is within the range of the collection
                {
                    return students[i];
                }
                else
                {
                    throw new ArgumentException("Error: student index out of range");
                }
            }
        }

        //indexer based on an String
        public Student this[String id]
        {
            get
            {
                //find matching student and return
                Student student = null;
                int count = students.Count(s => s.Id == id);        //the  count is set to the max size that is being used of the collection
                if (count == 1)
                {
                    student = students.Where(s => s.Id == id).First();      //ensuring the first match is returned
                    return student;
                }
                else
                {
                    throw new ArgumentException("no matching student found");
                }
                //alternative to LINQ: iterate using a loop to find matching student
            }
        }

        //iterate over student collection - foreach now possible on a StudentClass
        public IEnumerator GetEnumerator()
        {
            foreach (Student student in students)           //foreach loop calls the iterator method
            {
                yield return student;           //iterator
                //returns each element one at a time
            }
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            try
            {
                //create 2 students
                Student s1 = new Student("X00000111", "Joe Soap", Sex.Male);
                Student s2 = new Student("X00000222", "Jane Doe", Sex.Female);

                //create a class
                StudentClass oosdev2 = new StudentClass("oosdev2", "Gary Clynch");

                //add the students
                oosdev2.AddStudent(s1);
                oosdev2.AddStudent(s2);
                //oosdev2.AddStudent(s2);           //duplicate, throw an exception

                //print details of class and each student
                Console.WriteLine("Class: CRN " + oosdev2.Crn + "Lecture " + oosdev2.Lecturer);
                foreach (Student student in oosdev2)            //use iterator
                {
                    Console.WriteLine(student);
                }

                //try to find a player
                Student s = oosdev2["X00000111"];           //user overloaded indexer
                Console.WriteLine("Found " + s);
                s = oosdev2[1];                             //user overloaded indexer
                Console.WriteLine("Found " + s);
            }
            catch (ArgumentException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            Console.ReadLine();
        }
    }
}
