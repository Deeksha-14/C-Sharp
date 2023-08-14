using HRManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BOL;
using DAL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
//In C#, using System.Collections.Generic; is a namespace import statement that allows you to access classes and types defined in the System.Collections.Generic namespace. This namespace provides a collection of generic classes that are commonly used for working with collections of objects. List<T>, Dictionary<TKey, TValue>, HashSet<T>,  Queue<T> and Stack<T>

namespace HRManagement.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Register(int Id, string Name, string Location)
        {
            Department department = new Department(Id, Name, Location);
            DBManager.insert(department);
            return RedirectToAction("Department");
        }
    }
}
