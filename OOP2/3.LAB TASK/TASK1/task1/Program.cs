using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        public class Course
        {
            private string courseName;
            private string courseCode;
            private int courseCredit;

            // Properties
            public string CourseName
            {
                get { return courseName; }
                set { courseName = value; }
            }

            public string CourseCode
            {
                get { return courseCode; }
                set { courseCode = value; }
            }

            public int CourseCredit
            {
                get { return courseCredit; }
                set { courseCredit = value; }
            }

            // Constructors
            public Course()
            {
                Console.WriteLine("Course object created with default constructor.");
            }

            public Course(string courseName, string courseCode, int courseCredit)
            {
                this.courseName = courseName;
                this.courseCode = courseCode;
                this.courseCredit = courseCredit;
                Console.WriteLine("Course object created with parameterized constructor.");
            }

            // Member function
            public void showCourseInfo()
            {
                Console.WriteLine("COURSE NAME : " + courseName + "\n COURSE CODE : " + courseCode + "\nCOURSE CREDIT : " + courseCredit);
            }
        }
        static void Main(string[] args)
        {
            Course course = new Course();  
            Course course1 = new Course("C#","74398",23);   

            
            course1.showCourseInfo();    
        }
    }
}
