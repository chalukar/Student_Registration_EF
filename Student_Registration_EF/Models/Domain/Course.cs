using System.ComponentModel.DataAnnotations;

namespace Student_Registration_EF.Models.Domain
{
    public class Course
    {
       
        public int Id { get; set; }
        public string CoursesName { get; set; }

        public IEnumerable<Student> Students { get; set; }

    }
}
