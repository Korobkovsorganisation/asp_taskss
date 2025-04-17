using Microsoft.AspNetCore.Mvc;
using test_asp1.Models;
using lib1;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Greet(string name)
    {
        return Content($"Привет, {name}!");
    }
    public IActionResult UserInfo()
    {
        var user = new User { Name = "Иван Иванов", Age = 30 };
        return View(user);
    }
    public IActionResult Calc(Calc calc)
    {
        switch (calc.operation)
        {
            case "+":
                calc.result = MathFunctions.Add(calc.term1, calc.term2);
                return View(calc);
            case "-":
                calc.result = MathFunctions.Substract(calc.term1, calc.term2);
                return View(calc);
            case "*":
                calc.result = MathFunctions.Multiply(calc.term1, calc.term2);
                return View(calc);
            case "//":
                calc.result = MathFunctions.Devide(calc.term1, calc.term2);
                return View(calc);
            default:
                return View(calc);
        }
    }
}