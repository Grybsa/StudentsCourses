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

        public Course(int id, string title, int credits)
        {
            this.id = id;
            this.title = title;
            this.credits = credits;
        }
        public Course() { }
        public int getId() { return id; }
        public string getTitle() { return title; }
        public int getCredits() { return credits; }
        public void addStudentInternal(Student student)
        {
            if (student == null)
                return;

            if (students.Any(s => s.getId() == student.getId()))
                return;

            students.Add(student);
        }
        public bool addStudent(Student student)
        {
            if (students.Any(s => s.getId() == student.getId()))
            {  
                // Console.WriteLine("Kartojasi studentas su id: " + student.getId());
                return false; 
            }
            students.Add(student);
            student.addCourseInternal(this);
            return true;
        }
        public List<Student> getStudents() { return students; }

    }
}
