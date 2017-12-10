using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleModelDemo.Models
{
    public class Repository
    {
        public List<Course> GetCourses()
        {
            return new List<Course> {
                            new Course () {  CourseId = 1, CourseName = "Chemistry"},
                            new Course () {  CourseId = 2, CourseName = "Physics"},
                            new Course () {  CourseId = 3, CourseName = "Math" },
                            new Course () {  CourseId = 4, CourseName = "Computer Science" }
    };
        }
        public List<Faculty> GetFaculties() // courses
        {
            return new List<Faculty> {
                            new Faculty () {  FacultyId = 2, FacultyName= "C#" , creditHours= 4, maxEnrollment = 30,
                                AllotedCourses = new List<Course>
                                {new Course () { CourseId = 1, CourseName = "Chemistry"},
                                                 new Course () { CourseId = 2, CourseName = "Physics"},
                                                 new Course () { CourseId = 3, CourseName = "Math"},
                            }},



                            new Faculty () {  FacultyId = 2, FacultyName= "C#" , creditHours= 4, maxEnrollment = 30,
                                AllotedCourses = new List<Course>
                                {new Course () { CourseId = 2, CourseName = "Physics"},
                                                 new Course () { CourseId = 4, CourseName = "Computer Science"}
                            }},




                            new Faculty () {  FacultyId = 3, FacultyName= "Methu", creditHours = 3, maxEnrollment = 25,
                                AllotedCourses = new List<Course>
                                {new Course () { CourseId = 3, CourseName = "Math"},
                                                 new Course () { CourseId = 4, CourseName = "Computer Science"}
                            }}
    };
        }
        public List<Student> GetStudents() // section
        {
            List<Student> result = new List<Student> {
                                        new Student () { EnrollmentNo = 1, StudentName= "Jim", sectionID = 1, sectionDays = "M/W", sectionTime = "2:30", FacultyId = 1,
                                            EnrolledCourses = new List<Course>
                                            { new Course () { CourseId = 1, CourseName = "Chemistry"},
                                                              new Course () { CourseId = 2, CourseName = "Physics"},
                                                              new Course () { CourseId = 4, CourseName = "Computer Science"}
                                        }},

                                        new Student () {  EnrollmentNo = 2, StudentName= "Joli", sectionID = 2, sectionDays = "th/w", sectionTime = "4:30", FacultyId = 2,
                                            EnrolledCourses = new List<Course>
                                            { new Course () { CourseId = 2, CourseName = "Physics"} ,
                                                              new Course ()
                                                              { CourseId = 4, CourseName = "Computer Science"}
                                        }},

                                        new Student () {  EnrollmentNo = 3, StudentName= "Mortin", sectionID = 3, sectionDays = "M", sectionTime = "5:30", FacultyId = 3,
                                            EnrolledCourses = new List<Course>
                                            {  new Course () { CourseId = 3, CourseName = "Math"},
                                                               new Course () { CourseId = 4, CourseName = "Computer Science"}
                                        }}
                                };

            return result;
        }
    }
}