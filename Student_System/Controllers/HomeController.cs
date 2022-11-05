using Microsoft.AspNetCore.Mvc;
using Student_System.DataAccess;
using Student_System.Models;
using Student_System.Services;
using System.Diagnostics;

namespace Student_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService studentService;

        public HomeController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public IActionResult ExcellentStudents()
        {
            return View(studentService.ExcellentStudents());
        }

        public IActionResult Index()
        {
            return View(this.studentService.GetStudents());
        }
     
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveStudent(Student student) {
            this.studentService.AddStudent(student);
            return RedirectToAction("Index");
        }

        public IActionResult GetStudent(int id)
        {
            var student = this.studentService.GetById(id);
            return View(student);
        }

        public IActionResult EditStudent(Student student)
        {
            this.studentService.EditStudent(student);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteStudent(int id)
        {
            this.studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
