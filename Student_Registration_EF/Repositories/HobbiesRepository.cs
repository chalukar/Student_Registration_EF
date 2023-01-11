using Microsoft.EntityFrameworkCore;
using Student_Registration_EF.DataAccess;
using Student_Registration_EF.Models.Domain;

namespace Student_Registration_EF.Repositories
{
    public class HobbiesRepository : IHobbiesRepository
    {
        private readonly StudentDbContext _context;

        public HobbiesRepository(StudentDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Hobbie>> GetAllHobbiesAsync()
        {
            return await _context.Hobbies.ToListAsync();
        }
    }
}
