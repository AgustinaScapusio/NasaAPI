using Microsoft.AspNetCore.Mvc;
using NasaAPI.API;
using NasaAPI.Models;

using System.Diagnostics;

namespace NasaAPI.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly INasaAPI _nasaAPI;

        public HomeController(INasaAPI nasaAPI)
        {

            _nasaAPI = nasaAPI;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new IndexViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(IndexViewModel model)
        {
            var apod = await _nasaAPI.GetApodAsync(model.BirthDate);
            model.PictureOfTheDay = apod;
            return View(model);
        }

    }
}
