using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoPartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new student
            Student student = new Student(1, "Harry Potter");

            //Show the student's info:
            student.ShowStudentInfo();

            Console.ReadKey();
        }
    }
}
