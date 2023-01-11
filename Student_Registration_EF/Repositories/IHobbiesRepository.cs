using Student_Registration_EF.Models.Domain;

namespace Student_Registration_EF.Repositories
{
    public interface IHobbiesRepository
    {
        Task<IEnumerable<Hobbie>> GetAllHobbiesAsync();
    }
}
