using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnasPieShop.Models;
using AnasPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnasPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                IsPiesOfTheWeek = _pieRepository.IsPiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
