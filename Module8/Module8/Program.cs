using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Program
    {
        static void ListStudents(Course course)
        {
            foreach (Student s in course.studentList)
            {
                Console.WriteLine(s.firstName + " " + s.lastName);
            }

        }
        static void Main(string[] args)
        {

            Student student1 = new Student("Wang", "Gang", "April 23, 1983");
            Student student2 = new Student("Tony", "Stark", "January 03, 1994");
            Student student3 = new Student("Steve", "Rogers", "July 04, 1920");

            Teacher teacher = new Teacher("Bill", "Gates", "April 05, 1960");

            Course course = new Course("Programming with C#");
            course.addteacher(teacher);
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        course.addstudent(student1);
                        break;
                    case 1:
                        course.addstudent(student2);
                        break;
                    case 2:
                        course.addstudent(student3);
                        break;
                }
            }

            Degree degree = new Degree(course, "Bachelor of Science Degree");

            UProgram uprogram = new UProgram(degree, "Information Technology");
            ListStudents(course);
        }
    }
}
    

