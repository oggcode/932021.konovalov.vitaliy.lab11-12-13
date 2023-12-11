using Lab1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class CalcServiceController(CalcService service) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            return View(service.GetCalcModel());
        }

        public IActionResult PassUsingViewData()
        {
            var model = service.GetCalcModel();
            
            ViewData["X"] = model.X;
            ViewData["Y"] = model.Y;
            ViewData["Sum"] = model.Sum;
            ViewData["Div"] = model.Div;
            ViewData["Dif"] = model.Dif;
            ViewData["Mult"] = model.Mult;
            
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            var model = service.GetCalcModel();
            
            ViewBag.X = model.X;
            ViewBag.Y = model.Y;
            ViewBag.Sum = model.Sum;
            ViewBag.Dif = model.Dif;
            ViewBag.Mult = model.Mult;
            ViewBag.Div = model.Div;
            
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}