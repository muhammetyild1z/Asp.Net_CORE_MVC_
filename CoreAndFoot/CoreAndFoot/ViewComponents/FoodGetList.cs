using CoreAndFoot.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFoot.ViewComponents
{
    public class FoodGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FoodRepository foodRepository = new FoodRepository();

            
               // return View(foodRepository.TList().ToPagedList(page, 8));
            
            var FoodList = foodRepository.TList();
          // return View(foodRepository.TList().ToPagedList(1, 4));
             return View(FoodList);
        }

    }
}
