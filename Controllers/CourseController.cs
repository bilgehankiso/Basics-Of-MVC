using Microsoft.AspNetCore.Mvc;
using mvctrainings.Models;

namespace mvctrainings.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]//verileri paylaşırken post olarak belirtmek gereliyor eğer get yapıyorsak gerek yok
        [ValidateAntiForgeryToken]//veri gönderirken doğrulama
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository.Applications.Any(a => a.Email == model.Email))
            {
                ModelState.AddModelError("", "There is already application");
            }

            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();

        }
    }
}