using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int ID { get; set; }

        public string Name { get; set; }

        public int? Education { get; set; }

        public int? Innovation { get; set; }
        public int? Dissemination { get; set; }
        public int? Evaluation { get; set; }
        public int? Support { get; set; }


     //   public virtual Department Department { get; set; }
       // public virtual ICollection<Enrollment> Enrollments { get; set; }
        //public virtual ICollection<Instructor> Instructors { get; set; }
    }
}