using Microsoft.AspNetCore.Mvc;
using P1_ASP.Models;
using P1_ASP.Services;
using System.Diagnostics;

namespace P1_ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Vname = "Author: Antoni Davia Yll";
            ViewBag.V2 = "Programador ASPx.NET";
            return View();
        }

        public IActionResult StudiedCourses()
        {
            ViewBag.VStudyCourse = new RepositoryOStudiedCourses().GetStudiesCourses();
            return View();
        }
        public IActionResult Experiences()
        {
            ViewBag.VExperience = new RepositoryOfExperiences().GetExperiences();
            return View();
        }
        public IActionResult AboutMe()
        {
            return View();
        }
        public IActionResult Tech()
        {
            return View();
        }

        public IActionResult Projects()
        {
            ViewBag.VProject = new RepositoryOfProjects().GetProjects();
            return View();
        }
        public IActionResult SummaryCV()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}