using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Course
    {

        public string CourseName;
        public int CourseNumber;
        public Student[] Students;


        public void GetCourseDetail()
        {
            CourseName = Question.AskForString("Enter Course Name: ");
            CourseNumber = Question.AskForInteger("Enter Course Number: ");
        }

        public void GetClassDetail()
        {
            int size = Question.AskForInteger(" Enter Number of Students: ");
            Students = new Student[size];
            for (int i = 0; i < size; i++)
            {
                Students[i] = new Student();
                Students[i].GetStudentDetails();

            }
        }

        public void Print()
        {
            System.Console.WriteLine("The name of the course is " + CourseName + "." + "The Course Number is " + CourseNumber + "." + "Thereare " + Students.Length + " students in the class");
        }
    }
}
   

