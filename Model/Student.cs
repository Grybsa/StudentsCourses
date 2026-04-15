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

        Student(int id, string name, string surname, string nationality) { 
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

        public void setCourse(Course course) { 
            courses.Add(course); 
            course.addStudent(this);  // čia internetas patarė taip daryt, pats be šito būčiau palikęs
        }
        public List<Course> getCourses() { return courses; }
    }
}
