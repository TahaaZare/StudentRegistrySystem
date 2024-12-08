using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentId { get; set; }

        public Student(string name, int age, string studentId)
        {
            Name = name;
            Age = age;
            StudentId = studentId;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name},\n Age: {Age},\n Student ID: {StudentId}\n");
        }
    }
}
