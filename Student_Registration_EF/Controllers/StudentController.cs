using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Registration_EF.Models.Domain;
using Student_Registration_EF.Repositories;
using System.Net;

namespace Student_Registration_EF.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ICourcesRepository _courceRepository;
        private readonly IHobbiesRepository _hobbiesRepository;

        public StudentController(IStudentRepository studentRepository,ICourcesRepository courcesRepository,ICountryRepository countryRepository,IHobbiesRepository hobbiesRepository) 
        {
            _studentRepository = studentRepository;
            _courceRepository = courcesRepository;
            _countryRepository = countryRepository;
            _hobbiesRepository= hobbiesRepository;
        }
        public async Task<IActionResult> Index()
        {
            var student = await _studentRepository.GetAllStudentAsync();
            return View(student);
        }

        public async Task<IActionResult> Create()
        {
            var country = await _countryRepository.GetAllCountryAsync();
            var cource = await _courceRepository.GetAllCourceAsync();
            var hobbie = await _hobbiesRepository.GetAllHobbiesAsync();
            ViewData["CountryId"] = new SelectList(country, "Id", "CountryName");
            ViewData["CourseId"] = new SelectList(cource, "Id", "CoursesName");
            ViewData["HobbieId"] = new SelectList(hobbie, "Id", "HobbiesName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Models.DTO.AddStudentRequest addStudentRequest)
        {
            var student = new Models.Domain.Student
            {
                FirstName = addStudentRequest.FirstName,
                LastName = addStudentRequest.LastName,
                DateOfBirth = addStudentRequest.DateOfBirth,
                Email = addStudentRequest.Email,
                MobileNo = addStudentRequest.MobileNo,
                Gender = addStudentRequest.Gender,
                Address = addStudentRequest.Address,
                City = addStudentRequest.City,
                PinCode = addStudentRequest.PinCode,
                CourseId = addStudentRequest.CourseId,
                HobbieId = addStudentRequest.HobbieId,
                CountryId = addStudentRequest.CountryId,
            };

            await _studentRepository.AddAsync(student);
            return RedirectToAction("Index");


        }
    }
}
