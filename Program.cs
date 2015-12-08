using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {

        static void Main(string[] args)

        {
            string answer = "no";

            while (answer.ToLower().StartsWith("n"))
            {
                Course course = new Course();
                course.GetCourseDetail();
                course.GetClassDetail();
                course.Print();
                answer = Question.AskForString("Is the information above true ? ");
            }
        }
    }
}
