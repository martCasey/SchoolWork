using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsAndGenerics
{
    class SchoolClass
    {
        public string CRN { get; set; }                 //properties
        public string LecturerName { get; set; }
        ArrayList studentCollection;

        public SchoolClass(string crn, string lectureName)                  //constructor
        {
            this.CRN = crn;
            this.LecturerName = lectureName;
            this.studentCollection = new ArrayList();
        }

        public void AddNewStudent(Student student)                  //method to add a new student to the list
        {
            if (studentCollection.Contains(student.Name))
            {
                throw new Exception("Could not find match");
            }
            else
            {
                studentCollection.Add(student);
            }
        }

        //indexer return student at specifc position in the list
        Student this [int index]
        {
            get
            {
                return (Student)this.studentCollection[index];
            }
        }

        //indexer index collection based on specific index
        Student this [int index]
        {
            get
            {

            }
        }
    }
}
