using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChartsDemo.Models;

namespace ChartsDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PieChart()
        {
            return View();
        }

        public IActionResult BarChart()
        {
            return View();
        }

        public IActionResult ColumnChart()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult GetCountryVisits()
        {
            var visits = new List<Country>
            {
                new Country{ Name = "Spain", Visits = 10500 },
                new Country{ Name = "Italy", Visits = 25001 },
                new Country{ Name = "USA", Visits = 3500 },
                new Country{ Name = "UK", Visits = 4500 },
                new Country{ Name = "Turkey", Visits = 55000 }
            };
            return Json(visits);
        }

        public JsonResult GetProfit()
        {
            var profit = new List<Profit>
            {
                new Profit{ Year = 2015, Amount = 1500.05m, Color = "#FF4500" },
                new Profit{ Year = 2016, Amount = 2500.05m, Color = "#FFD700" },
                new Profit{ Year = 2017, Amount = 3500.05m, Color = "#7CFC00" },
                new Profit{ Year = 2018, Amount = 4500.05m, Color = "#0000FF" },
                new Profit{ Year = 2019, Amount = 5500.05m, Color = "#708090" },
            };
            return Json(profit);
        }

        public JsonResult GetCategories()
        {
            var categories = new List<CategoryViewModel>
            {
                new CategoryViewModel{ Name = "Japan", Value = 500 },
                new CategoryViewModel{ Name = "Russia", Value = 550 },
                new CategoryViewModel{ Name = "USA", Value = 1000 },
                new CategoryViewModel{ Name = "UK", Value = 1005 },
                new CategoryViewModel{ Name = "Turkey", Value = 250 }
            };
            return Json(categories);
        }
    }
}
