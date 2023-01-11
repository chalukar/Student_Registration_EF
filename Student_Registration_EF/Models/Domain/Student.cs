using System.ComponentModel.DataAnnotations;

namespace Student_Registration_EF.Models.Domain
{
    public class Student
    {
      
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public int CourseId { get; set; }

        public int HobbieId { get; set; }

        public int CountryId { get; set; }

        public Course Courses { get; set; }

        public Country Country { get; set; }

        public Hobbie Hobbies { get; set; }



    }
}
