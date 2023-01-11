using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Student_Registration_EF.Models.DTO
{
    public class AddStudentRequest
    {

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "First Name length can't be more than 30.")]
        [RegularExpression(@"(\D)+",ErrorMessage ="Numbers Not Allow")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Last Name length can't be more than 30.")]
        [RegularExpression(@"(\D)+", ErrorMessage = "Numbers Not Allow")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10, ErrorMessage = "Phone Number length can't be more than 10.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Mobile No must be numbers")]
        public string MobileNo { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }


        [Display(Name = "City")]
        [StringLength(30, ErrorMessage = "City length can't be more than 30.")]
        [RegularExpression(@"(\D)+", ErrorMessage = "Numbers Not Allow")]
        public string City { get; set; }

        [Display(Name = "Pin Code")]
        [MaxLength(12)]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Pin Code must be numeric")]
        public string PinCode { get; set; }

        [Required(ErrorMessage ="Country is Required", AllowEmptyStrings =false)]
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Hobbies is Required", AllowEmptyStrings = false)]
        [Display(Name = "Hobbies")]
        public int HobbieId { get; set; }

        [Required(ErrorMessage = "Courses is Required", AllowEmptyStrings = false)]
        [Display(Name = "Courses Applied For")]
        public int CourseId { get; set; }

 

        
    }
}
