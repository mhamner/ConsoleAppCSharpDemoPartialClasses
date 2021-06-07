using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoPartialClasses
{
    public partial class Student
    {
        //Constructor
        public Student(int studentId, string studentName)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Student ID: {this.StudentId}, Student Name: {this.StudentName}.");
        }
    }
}
