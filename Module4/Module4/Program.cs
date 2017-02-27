using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            student[] studentsInClass = new student[5];
            for(int i = 0; i <5; i++)
            {
                studentsInClass[i] = new student("John","Doe","May 14, 1987");
            }
            foreach(student s in studentsInClass)
            {
                Console.WriteLine("{0} {1} was born on: {2}", s.firstName, s.lastName, s.birthday);
            }
        }
        struct student
        {
           public string firstName, lastName, birthday;
           public student(string fName, string lName, string birthday)
            {
                this.firstName = fName;
                this.lastName = lName;
                this.birthday = birthday;
            }
        }
        struct teacher
        {
            public string firstName, lastName, birthday;
            public teacher(string firstName, string lastName, string birthday)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthday = birthday;
            }
        }
        struct UProgram
        {
            public string nameOfTheProgram,  departmentHead,  degrees;
            public UProgram(string nameOfTheProgram, string departmentHead, string degrees)
            {
                this.nameOfTheProgram = nameOfTheProgram;
                this.departmentHead = departmentHead;
                this.degrees = degrees;
            }
        }
        struct Course
        {
            public string courseName, credits, duration;
            public Course(string courseName, string credits, string duration)
            {
                this.courseName = courseName;
                this.credits = credits;
                this.duration = duration;
            }
        }
    }
}
