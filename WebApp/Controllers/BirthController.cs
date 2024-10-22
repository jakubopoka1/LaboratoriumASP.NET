using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class BirthController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Result(Birth birth)
    {
        if (birth.IsValid())
        {
            return View("Error");
        }

        return View(birth);
    }
    
    public IActionResult Form()
    {
        return View();
    }
}