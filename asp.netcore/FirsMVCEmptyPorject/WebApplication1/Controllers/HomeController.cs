using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["tittle"] = "Index page!!";
        ViewBag.Status = "My first asp.net core mvc project";
        ViewBag.StudentName = "Mircafar";
        return View();
    }

    public IActionResult Error(int statusCode = 404)
    {
        ViewBag.ErrorId = statusCode;
        return View();
    }
}
