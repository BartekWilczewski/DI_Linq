using DiDemo;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGuidWrapper _guidWrapper;
        private readonly IGuidWrapper2 _guidWrapper2;

        public HomeController(ILogger<HomeController> logger, IGuidWrapper wrapper, IGuidWrapper2 wrapper2)
        {
            _logger = logger;
            _guidWrapper = wrapper;
            _guidWrapper2 = wrapper2;
        }

        public IActionResult Index()
        {
            return View(new List<string>
            {
                _guidWrapper.GetGuid(),
                _guidWrapper2.GetGuid(),
            });
        }

        public IActionResult Privacy()
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