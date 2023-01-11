using Student_Registration_EF.Models.Domain;

namespace Student_Registration_EF.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountryAsync();
    }
}
