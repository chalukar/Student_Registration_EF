using System.ComponentModel.DataAnnotations;

namespace Student_Registration_EF.Models.Domain
{
    public class Country
    {
       
        public int Id { get; set; }
        public string CountryName { get; set; }

        public IEnumerable<Student> Students { get; set; }

    }
}
