using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();

            var teachers = new List<Teacher>
            {
            new Teacher{ID=1050,Name="Smith/Wesson",Education=35, Innovation = 10, Dissemination = 10, Evaluation = 10, Support = 5},
            new Teacher{ID=1051,Name="Laurel/Hardy",Education=0, Innovation =5, Dissemination = 0, Evaluation = 0, Support = 5},
            new Teacher{ID=10504,Name="Rhet/Link",Education=10, Innovation = 10, Dissemination = 10, Evaluation = 10, Support = 5},
            new Teacher{ID=105340,Name="Butler",Education=15, Innovation = 5, Dissemination = 10, Evaluation = 10, Support = 5},
            new Teacher{ID=10540,Name="Abraham/Lindeloff/Cuse",Education=10, Innovation = 35, Dissemination = 10, Evaluation = 10, Support = 5},
            new Teacher{ID=10150,Name="Hilton",Education=35, Innovation = 35, Dissemination = 10, Evaluation = 10, Support = 5},
            new Teacher{ID=134050,Name="Rague",Education=0, Innovation = 0, Dissemination = 0, Evaluation = 0, Support = 1},
            new Teacher{ID=10830,Name="Wediman/Jensen",Education=0, Innovation = 0, Dissemination = 0, Evaluation = 0, Support = 1},
            new Teacher{ID=100,Name="Phineas/Ferb",Education=35, Innovation = 25, Dissemination = 5, Evaluation = 10, Support = 5},
            new Teacher{ID=190,Name="Lock",Education=15, Innovation = 35, Dissemination = 10, Evaluation = 10, Support = 5},
            new Teacher{ID=105170,Name="Sheperd",Education=0, Innovation = 35, Dissemination = 10, Evaluation = 5, Support =85},
            new Teacher{ID=10506,Name="sawyer/Julia",Education=20, Innovation = 35, Dissemination =8, Evaluation = 10, Support = 8},

            };
            teachers.ForEach(s => context.Teachers.Add(s));
            context.SaveChanges();
        }
    }
}