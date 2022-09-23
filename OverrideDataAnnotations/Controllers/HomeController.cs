using Microsoft.AspNetCore.Mvc;

namespace OverrideDataAnnotations.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Playground()
    {
        return View();
    }
}
