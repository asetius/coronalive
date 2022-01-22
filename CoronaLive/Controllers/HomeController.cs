using CoronaLive.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoronaLive.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryRepository _repository;

        public HomeController(ICountryRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var list = _repository.Countries;
            return View(list);
        }
    }
}