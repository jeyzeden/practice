using System.Collections.Generic;
using System.Web.Mvc;
using calculator.TwoArgument;

namespace Webcalculator.Controllers
{
    public class HomeController : Controller
    {
        private List<SelectListItem> operations = new List<SelectListItem>()
        {
            new SelectListItem()
            {
                Text = "+", Value = "Addition"
            },new SelectListItem()
            {
                Text = "*", Value = "Multiply"
            },new SelectListItem()
            {
                Text = "x^3+y^3", Value = "AdditionCube"
            },new SelectListItem()
            {
                Text = "x^3*y^3", Value = "MultiplyCube"
            },new SelectListItem()
            {
                Text = "x^2+y^2", Value = "AdditionSquare"
            },new SelectListItem()
            {
                Text = "x^2*y^2", Value = "MultiplySquare"
            },new SelectListItem()
            {
                Text = "/", Value = "Division"
            },new SelectListItem()
            {
                Text = "x^3/y^3", Value = "DivisionCube"
            },new SelectListItem()
            {
                Text = "x^2/y^2", Value = "DivisionSquare"
            },new SelectListItem()
            {
                Text = "Min", Value = "Min"
            },new SelectListItem()
            {
                Text = "Max", Value = "Max"
            },new SelectListItem()
            {
                Text = "-", Value = "Substraction"
            },new SelectListItem()
            {
                Text = "x^2-y^2", Value = "SubstractionSquare"
            },new SelectListItem()
            {
                Text = "x^y", Value = "Pow"
            }
        };
    
        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            ViewBag.result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.operations = operations;
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.operations = operations;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}