using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mylatemvc.Models
{
   public class Major
   {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [Key]
      public int MajorID { get; set; }
      public string MajorTitle { get; set; }
      public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; }
   }
}