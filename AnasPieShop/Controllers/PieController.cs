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
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List (string category)
        {
            IEnumerable<Pie> pies;
            string curentCategory;
            if(string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                curentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category).OrderBy(p => p.PieId);
                curentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new PieListViewModel
            {
                Pies = pies,
                CurrentCategory = curentCategory
            });
        }

        public IActionResult Details (int id)
        {
            var pie = _pieRepository.GetPieById(id);
                if (pie == null)
                return NotFound();
           return View(pie);
        }

    }
}
