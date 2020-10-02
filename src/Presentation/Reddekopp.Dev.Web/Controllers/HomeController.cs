using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reddekopp.Dev.Web.Factories;
using Reddekopp.Dev.Web.Models;
using System;
using System.Diagnostics;

namespace Reddekopp.Dev.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IViewModelFactory _viewModelFactory;

        public HomeController(ILogger<HomeController> logger, IViewModelFactory viewModelFactory)
        {
            _logger = logger;
            _viewModelFactory = viewModelFactory;
        }

        public IActionResult Index()
        {
            var model = _viewModelFactory.CreateIndexViewModel();
            return View(model);
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
    }
}
