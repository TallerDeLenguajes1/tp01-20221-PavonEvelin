using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp_Problema4.Models;

namespace WebApp_Problema4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string Problema4(string kmt, string lit)
        {
            try
            {
                double a1 = Convert.ToDouble(kmt);
                double b1 = Convert.ToDouble(lit);
                return $"Kilometro por litro: {kmt} / {lit} = {a1 / b1}";

            }
            catch (DivideByZeroException ex)
            {
                return $"Error: {ex.Message}";
            }
            catch (FormatException ex)
            {
                return $"Por favor, ingrese dos numeros! \nError: {ex.Message}";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
