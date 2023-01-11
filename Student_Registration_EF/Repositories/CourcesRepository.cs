using Microsoft.EntityFrameworkCore;
using Student_Registration_EF.DataAccess;
using Student_Registration_EF.Models.Domain;

namespace Student_Registration_EF.Repositories
{
    public class CourcesRepository : ICourcesRepository
    {
        private readonly StudentDbContext _context;

        public CourcesRepository(StudentDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Course>> GetAllCourceAsync()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}
