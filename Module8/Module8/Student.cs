using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Student : Person
    {
        Stack<int> grades = new Stack<int>();
        public Student(string fName, string lName, string birthday) : base(fName, lName, birthday)
        {
            this.firstName = fName; this.lastName = lName; this.birthday = birthday;

        }

        public void takeATest()
        {
            Random r = new Random();
            grades.Push(r.Next());
        }
    }
}
