using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using homework4.Models;
namespace homework4.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var instructors = new List<Instructor>
            {
            new Instructor{ProposalName="Smith/Wesson",Experience=0,Innovation=35, Dissmination= 10, Evaluation = 10, Support = 5},
            new Instructor{ProposalName="Laurel/Hardy",Experience=15,Innovation=20, Dissmination= 10, Evaluation = 10, Support = 10},
            new Instructor{ProposalName="Rhett/Link/Wesson",Experience=0,Innovation=0, Dissmination= 0, Evaluation = 0, Support = 5},
            new Instructor{ProposalName="Butler",Experience=10,Innovation=10, Dissmination= 5, Evaluation = 5, Support = 2},
            new Instructor{ProposalName="Abrams/Lindeloff/cuse",Experience=15,Innovation=15, Dissmination= 5, Evaluation = 5, Support = 10},
            new Instructor{ProposalName="Hilton",Experience=35,Innovation=35, Dissmination= 10, Evaluation = 10, Support = 10},
            new Instructor{ProposalName="Rague",Experience=30,Innovation=30, Dissmination= 8, Evaluation = 0, Support = 0},
            new Instructor{ProposalName="Weidman/Jensen",Experience=0,Innovation=0, Dissmination= 0, Evaluation = 0, Support = 0},
            new Instructor{ProposalName="phineas/Ferb",Experience=35,Innovation=25, Dissmination= 8, Evaluation = 8, Support = 10},
            new Instructor{ProposalName="locke",Experience=25,Innovation=35, Dissmination= 8, Evaluation = 8, Support = 5},
            new Instructor{ProposalName="Shepherd",Experience=5,Innovation=5, Dissmination= 5, Evaluation = 5, Support = 5},
            new Instructor{ProposalName="Sawyer/Juila",Experience=30,Innovation=30, Dissmination= 8, Evaluation = 8, Support = 8},

            };

            instructors.ForEach(s => context.Instructors.Add(s));

        }
    }
}