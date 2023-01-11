using Microsoft.EntityFrameworkCore;
using Student_Registration_EF.DataAccess;
using Student_Registration_EF.Models.Domain;

namespace Student_Registration_EF.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly StudentDbContext _context;

        public CountryRepository(StudentDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Country>> GetAllCountryAsync()
        {
            return await _context.Countries.ToListAsync();
        }
    }
}
