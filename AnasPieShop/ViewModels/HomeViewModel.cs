using AnasPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnasPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> IsPiesOfTheWeek { get; set; }
    }
}
