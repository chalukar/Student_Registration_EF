using Microsoft.EntityFrameworkCore;
using Student_Registration_EF.DataAccess;
using Student_Registration_EF.Models.Domain;

namespace Student_Registration_EF.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context) 
        {
            _context = context;
        }

        public async Task AddAsync(Student student)
        {
           await _context.Students.AddAsync(student);
           await _context.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<Student>> GetAllStudentAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
