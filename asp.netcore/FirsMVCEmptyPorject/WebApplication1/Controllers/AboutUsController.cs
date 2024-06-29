using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class AboutUsController : Controller
{
    public IActionResult Index()
    {
        ViewData["tittle"] = "AboutUs page!!";
        return View();
    }
    
    public IActionResult Experience()
    {
        var profile = new Profile
        {
            Name = "Mircafar",
            Raiting = 5
        };

        return View(profile);
    }
}
