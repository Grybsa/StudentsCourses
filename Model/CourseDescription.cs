using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCourses.Model
{
    internal class CourseDescription
    {
        int courseId;
        string descriptionLT;
        string descriptionEN;

        CourseDescription(int courseId, string descriptionLT, string descriptionEN) { 
            this.courseId = courseId;
            this.descriptionLT = descriptionLT;
            this.descriptionEN = descriptionEN;
        }
        CourseDescription() { }
        public int getCourseId() { return courseId};
        public string getDescriptionLT() { return descriptionLT; }
        public string getDescriptionEN() { return descriptionEN; }
    }
}
