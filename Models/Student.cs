using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mylatemvc.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Surname { get; set; }
        public string StudentName { get; set; }
        public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; }
    }
}