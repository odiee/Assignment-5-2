using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Student
    {

        public string StudentName;
        public string StudentNumber;

        public void GetStudentDetails()
        {
            StudentName = Question.AskForString("Enter Student Name: ");
            StudentNumber = Question.AskForString("Enter Student Number: ");
        }

        public void Print()
        {
            System.Console.WriteLine("Student's Name: " + StudentName + "Student's StudentNumber: " + StudentNumber);
        }
    }
}
