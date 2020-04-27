using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnasPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie>AllPies { get;}
        IEnumerable<Pie> IsPiesOfTheWeek { get;}
        Pie GetPieById(int pieID);
    }
}
