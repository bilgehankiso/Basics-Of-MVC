using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            var names = new string[] { "ahmet", "mehmet", "ali" };
            return View(names);
        }
        public IActionResult Index3()
        {
            var list = new List<Employee>(){
                new Employee{Id = 1, Age = 11, FirstName = "Ali",LastName="Can"},
                new Employee{Id = 2, Age = 11, FirstName = "Can",LastName="Dal"},
                new Employee{Id = 3, Age = 31, FirstName = "Cansu",LastName="Dalgıc"}

            };
            return View("Index3", list);
        }
    }
}
