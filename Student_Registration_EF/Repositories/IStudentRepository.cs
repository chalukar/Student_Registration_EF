using Student_Registration_EF.Models.Domain;

namespace Student_Registration_EF.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable <Student>> GetAllStudentAsync();

        Task AddAsync(Student student);
    }
}
