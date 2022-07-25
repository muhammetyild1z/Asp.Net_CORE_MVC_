using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFoot.Repositories;
namespace CoreAndFoot.ViewComponents
{
    public class FoodListByCatagori:ViewComponent
    {

        FoodRepository FoodRepository = new FoodRepository();

        public IViewComponentResult Invoke(int id)
        {
            var foodGroup = FoodRepository.List(x=> x.CatagoryID==id );
            return View(foodGroup);
        }
        
    }
}
