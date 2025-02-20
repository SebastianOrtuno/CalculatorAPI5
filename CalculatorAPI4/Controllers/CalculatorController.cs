using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI4.Controllers;

public class CalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}