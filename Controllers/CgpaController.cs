using Microsoft.AspNetCore.Mvc;
using MVC_CGPA.Repository.Interface;
using MVC_CGPA.ViewModel;

namespace MVC_CGPA.Controllers
{
    public class CgpaController : Controller
    {
        private readonly ICgpa _cgpa;
        public CgpaController(ICgpa cgpa)
        {
            _cgpa = cgpa;
        }

        [HttpGet]
        public IActionResult CheckGrade()
        {
            return View(new List<CgpaDetailsVM> { new CgpaDetailsVM() });
        }


        [HttpPost]
        public IActionResult CheckGrade(List<CgpaDetailsVM> details)
        {
            var cgpa = _cgpa.CalculateCgpa(details);
            return RedirectToAction("DisplayCgpa", new { cgpa });

        }
        public IActionResult DisplayCgpa(decimal cgpa)
        {
            return View(cgpa);
        }
    }
}
