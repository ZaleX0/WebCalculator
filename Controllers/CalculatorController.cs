using Microsoft.AspNetCore.Mvc;
using WebCalculator.Models;
using WebCalculator.Services;

namespace WebCalculator.Controllers;
public class CalculatorController : Controller
{
    private readonly CalculatorService _service;

    public CalculatorController(CalculatorService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        return View(new Calculator());
    }

    [HttpPost]
    public IActionResult Index(Calculator calculator)
    {
        calculator.Result = _service.Calculate(calculator);
        return View(calculator);
    }
}
