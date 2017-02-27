using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class Course
    {
        public string courseName;
      
    public    ArrayList studentList = new ArrayList();
       
        public ArrayList teacherList = new ArrayList();
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
