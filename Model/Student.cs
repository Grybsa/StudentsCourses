using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCourses.Model
{
    internal class Student
    {
        int id;
        string name;
        string surname;
        string nationality;
        List<Course> courses = new List<Course>();

        public Student(int id, string name, string surname, string nationality)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.nationality = nationality;
        }
        Student() { }
        public int getId() { return id; }
        public string getName() { return name; }
        public string getSurname() { return surname; }
        public string getNationality() { return nationality; }

        public bool addCourse(Course course)
        {

            if (courses.Any(x => x.getId() == course.getId()))
            {
                return false;
            }
            courses.Add(course);
            course.addStudentInternal(this);
            return true;

        }
        public void addCourseInternal(Course course)
        {
            if (courses.Any(c => c.getId() == course.getId()))
                return;

            courses.Add(course);
        }
        public List<Course> getCourses() { return courses; }
    }
}
