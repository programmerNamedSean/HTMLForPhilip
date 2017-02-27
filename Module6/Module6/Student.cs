using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Student : Person
    {
        
        public Student(string fName, string lName, string birthday) : base(fName, lName, birthday)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.birthday = birthday;
        }

        public int takeTest()
        {
             Random randoms = new Random(100);
            return randoms.Next();
        }
    }
}
