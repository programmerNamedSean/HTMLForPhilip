using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetUProgramInformation();
            GetDegreeInformation();
            GetCourseInformation();
        }
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday: ");
            string birthday = Console.ReadLine();
            PrintStudentDetails(firstName, lastName, birthday);
        }
        static void PrintStudentDetails(string firstName, string lastName, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthday);
        }
        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday: ");
            string birthday = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, birthday);
        }
        static void PrintTeacherDetails(string firstName, string lastName, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthday);
        }
        static void GetUProgramInformation()
        {
            Console.WriteLine("Enter the name of the program: ");
            string nameOfTheProgram = Console.ReadLine();
            Console.WriteLine("Enter the name of the department head: ");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Enter the Degrees: ");
            string degrees = Console.ReadLine();
            PrintUProgramDetails(nameOfTheProgram, departmentHead, degrees);
        }
        static void PrintUProgramDetails(string nameOfTheProgram, string departmentHead, string degrees)
        {
            Console.WriteLine("{0} is the name of the program, and the department head is {1}, and the degrees offered are: {2}", nameOfTheProgram, departmentHead, degrees);
        }
        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the name of the degree: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the credits required: ");
            string creditsRequired = Console.ReadLine();
            Console.WriteLine("Enter the average time to complete in years: ");
            string years = Console.ReadLine();
            PrintDegreeDetails(name, creditsRequired, years);
        }
        static void PrintDegreeDetails(string name, string creditsRequired, string years)
        {
            Console.WriteLine("{0} the credits required for this is {1}, and it usually takes about {2}", name, creditsRequired, years);
        }
        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the name of the course: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the number of credits: ");
            string credits = Console.ReadLine();
            Console.WriteLine("Enter the duration of the class: ");
            string duration = Console.ReadLine();
            PrintCourseDetails(courseName, credits, duration);
        }
        static void PrintCourseDetails(string courseName, string credits, string duration)
        {
            Console.WriteLine("{0} is worth {1} credits and the duration of the class is: {2}", courseName, credits, duration);
        }
        static void birthdayValidator()
        {
            throw new NotImplementedException();
        }
    }
}
