using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.StudentsClass
{
    public class Student
    {
        
            public Student(string firstName, string lastName, double grade)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}: {grade:f2}";
            }

        
    }
}
