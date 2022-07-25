using CoreAndFoot.Data.Models;
using CoreAndFoot.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreAndFoot.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        Context c = new Context();
        FoodRepository foodRepository = new FoodRepository();

        public IActionResult Index( )
        {
            return View();
        }

        public IActionResult CatagoryDetails(int id )
        {
            var catadd = c.Catagories.Where(x => x.CatagoryID == id).FirstOrDefault() ;
           ViewBag.catad = catadd.CatagoryName;
            ViewBag.x = id;
            return View();
        }
    }
}
