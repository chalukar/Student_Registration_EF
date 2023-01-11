using System.ComponentModel.DataAnnotations;

namespace Student_Registration_EF.Models.Domain
{
    public class Hobbie
    {
       
        public int Id { get; set; }

        public string HobbiesName { get; set; }

        public IEnumerable<Student> Students { get; set; }
    }
}
