using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Teacher : Person
    {
        public Teacher(string fName, string lName, string birthday) : base(fName, lName, birthday)
        {
            this.firstName = fName; this.lastName = lName; this.birthday = birthday;
        }

        public void giveTest()
        {

        }
    }
}
