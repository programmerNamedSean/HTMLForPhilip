using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Course
    {
        public string courseName;
        public Student[] studentList = new Student[3];
        public Teacher[] teacherList = new Teacher[3];
        public void addstudent(Student s, int x)
        {
            studentList[x] = s;
        }
        public void addteacher(Teacher t, int x)
        {
            teacherList[x] = t;
        }
        public Course(string courseName)
        {
            this.courseName = courseName;
        }
    }
}
