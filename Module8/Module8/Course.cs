using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Course
    {
        public string courseName;

        public List<Student> studentList = new List<Student>();
        public List<Teacher> teacherList = new List<Teacher>();
     
        public void addstudent(Student s)
        {

            studentList.Add(s);
        }
        public void addteacher(Teacher t)
        {

            teacherList.Add(t);
        }
        public Course(string courseName)
        {
            this.courseName = courseName;
        }
    }
}

