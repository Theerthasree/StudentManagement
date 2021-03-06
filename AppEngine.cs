using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentmanagementsystem
{
    interface AppEngine
    {
        public void introduce(Course course);
        public List<Course> listOfCourses(string choice);
        public void register(Student student);
        public List<Student> listOfStudents();
        public void addEnrollment(Student student, Course course);
        public List<Enroll> listOfEnrollments();
    }
}