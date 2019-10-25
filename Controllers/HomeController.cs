using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Metodos_Numericos.Models;

namespace Metodos_Numericos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(string equation, float xi, float xs)
        {
            List<List<float>> result = new Metodos_Numericos(equation, xi, xs)
            return View(result);
        }

        public IActionResult iteraciones_sucesivas(string equation, float xi, float xs)
        {
            List<List<float>> result = new Metodos_Numericos(equation, xi, xs)
            return View(result);
        }

        public IActionResult regla_falsa(string equation, float xi, float xs)
        {
            List<List<float>> result = new Metodos_Numericos(equation, xi, xs)
            return View(result);
        }

        public IActionResult biseccion(string equation, float xi, float xs)
        {
            List<List<float>> result = new Metodos_Numericos(equation, xi, xs)
            return View(result);
        }

        public IActionResult punto_fijo(string equation, float xi, float xs)
        {
            List<List<float>> result = new Metodos_Numericos(equation, xi, xs)
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
