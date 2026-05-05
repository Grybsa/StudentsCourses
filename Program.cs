using StudentsCourses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Petras", "Petraitis", "Lithuanian");
            student1.addCourse(new Course(1, "Mathematics", 5));
            student1.addCourse(new Course(2, "Physics", 4));
            student1.addCourse(new Course(1, "Chemistry", 4));

            Course course1 = new Course(4, "Biology", 3);
            course1.addStudent(student1);
            course1.addStudent(student1);
            course1.addStudent(new Student(2, "Jonas", "Jonaitis", "Lithuanian"));
        }
    }
}
