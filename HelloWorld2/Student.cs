using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            this.ID = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
