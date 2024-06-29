using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;
using MovieApi.Services;
using System.Diagnostics;

namespace MovieApi.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync(string movieName = "Matrix")
        {
            MovieApiService movieApiService = new MovieApiService();
            var result = await movieApiService.Search(movieName);
            return View(result);
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
