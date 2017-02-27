using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Degree
    {
        public Course course;
        public string name;
        public Degree(Course course, string name)
        {
            this.course = course;
            this.name = name;
        }
    }
}
