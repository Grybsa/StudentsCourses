using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCourses.Model
{
    internal class Course
    {
        int id;
        string title;
        int credits;
        List<Student> students = new List<Student>();

        Course(int id, string title, int credits) { 
            this.id = id;
            this.title = title;
            this.credits = credits;
        }   
        Course() { }
        public int getId() { return id; }
        public string getTitle() { return title; }
        public int getCredits() { return credits; }
        public void addStudent(Student student) { 
            students.Add(student); 
        }
        public List<Student> getStudents() { return students; }

    }
}
