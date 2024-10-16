using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class CalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Calculator(Operator? op, double? x, double? y)
    {
        if (x is null || y is null)
        {
            ViewBag.ErrorMessage = "Niepoprawny format liczby x lub y lub brak parametru!";
            return View("CalculatorError");
        }

        if (op is null)
        {
            ViewBag.ErrorMessage = "Nieznany operator!";
            return View("CalculatorError");
        }
        
        double? result = 0.0d;
        switch (op)
        {
            case Operator.Add:
                result = x + y;
                ViewBag.Operator = "+";
                break;
            case Operator.Sub:
                result = x - y;
                ViewBag.Operator = "-";
                break;
            case Operator.Mul:
                result = x * y;
                ViewBag.Operator = "*";
                break;
            case Operator.Div:
                result = x / y;
                ViewBag.Operator = ":";
                break;
        }
        ViewBag.Result = result;
        ViewBag.X = x;
        ViewBag.Y = y;
        return View();
    }
    
    public IActionResult Form()
    {
        return View();
    }
}