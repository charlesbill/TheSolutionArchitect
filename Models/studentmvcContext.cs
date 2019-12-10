using Microsoft.EntityFrameworkCore;
namespace mylatemvc.Models
{
    public class studentmvcContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Major> Majors { get; set; }
		public DbSet<StudentEnrollment> StudentEnrollments { get; set; }
		public studentmvcContext(DbContextOptions<studentmvcContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-875MKLR\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}