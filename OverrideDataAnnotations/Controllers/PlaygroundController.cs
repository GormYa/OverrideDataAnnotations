using Microsoft.AspNetCore.Mvc;
using OverrideDataAnnotations.ViewModels;

namespace OverrideDataAnnotations.Controllers;

public class PlaygroundController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(ExampleViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        TempData["Status"] = "Success";
        return RedirectToAction("Success");
    }

    public IActionResult Success()
    {
        if (!TempData.TryGetValue("Status", out var status))
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}
