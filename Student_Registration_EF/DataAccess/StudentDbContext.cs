using Microsoft.EntityFrameworkCore;
using Student_Registration_EF.Models.Domain;
using Student_Registration_EF.Models.DTO;

namespace Student_Registration_EF.DataAccess
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Hobbie> Hobbies { get; set; }

       
    }
}
