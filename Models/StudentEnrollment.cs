using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mylatemvc.Models
{
    public class StudentEnrollment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EnrollmentID { get; set; }
        public int MajorID { get; set; }
        public int StudentID { get; set; }
        public virtual Major Major { get; set; }
        public virtual Student Student { get; set; }
    }
}