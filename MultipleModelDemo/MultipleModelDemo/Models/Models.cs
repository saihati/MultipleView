using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleModelDemo.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }

    public class Faculty //course
    {
        public int FacultyId { get; set; } // employee id --> course number
        public string FacultyName { get; set; } // course name

        public int creditHours { get; set; }
        public int maxEnrollment { get; set; }

        public List<Course> AllotedCourses { get; set; }
    }

    public class Student // section
    {
        public int sectionID { get; set; }

        public int EnrollmentNo { get; set; } //section number
        public int FacultyId { get; set; } // employee id --> course number


        public string sectionDays { get; set; }

        public string sectionTime { get; set; }
        public string StudentName { get; set; } // no need
        public List<Course> EnrolledCourses { get; set; }
    }
}