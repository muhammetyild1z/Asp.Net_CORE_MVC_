using CoreAndFoot.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFoot.ViewComponents
{
    public class CatagoryGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CatagoryRepository catagoryRepository = new CatagoryRepository();

            var catagoryList = catagoryRepository.TList();
            return View(catagoryList);
        }
    }
}
