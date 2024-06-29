using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class PrivacyController : Controller
{
    public IActionResult Index()
    {
        ViewData["tittle"] = "Privacy page!!";
        return View();
    }
}
