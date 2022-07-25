using CoreAndFoot.Data;
using CoreAndFoot.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFoot.Controllers
{
   
    public class Chart : Controller
    {
        Context c = new Context();
        /////
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public IActionResult Index2()
        //{
        //    return View();
        //}
        //public IActionResult UrunGorsel1()
        //{   
        //    return Json(ProList());
        //}
        //public List<Chartss> ProList()
        //{
        //    List<Chartss> cs2 = new List<Chartss>();
        //    cs2.Add(new Chartss()
        //    {
        //        Proname="Computer",
        //        Stock=250
        //    });
        //    cs2.Add(new Chartss()
        //    {
        //        Proname = "lcd",
        //        Stock = 75
        //    });
        //    cs2.Add(new Chartss()
        //    {
        //        Proname = "Usp Disk",
        //        Stock = 200
        //    });
        //    return cs2;
        //}
      
        /// /////////////// Context
       
        public IActionResult Pie_Chart()
        {
            return View();
        }
        public IActionResult Column_Chart()
        {
            return View();
        }
        ///Istatistik
        public IActionResult UrunGorsel()
        {
            return Json(FoodList());
        }
        public List<foodList > FoodList()
        {
            List<foodList> cs = new List<foodList>();
            using (var c = new Context())
            {
                cs = c.Foods.Select(X => new foodList
                {
                    foodname = X.Name,
                    stock = X.Stock
                }).ToList();
           }
                return cs;

        }

        public IActionResult Statistics()
        {
            // Tüm Ürün kaç tane
            var FoodCount = c.Foods.Count();
            ViewBag.FoodCount = FoodCount;
            var CatagoriesCount = c.Catagories.Count();
            ViewBag.CatagoriesCount = CatagoriesCount;

            // Hnagi katagoride kaçar tane 
            var FruitID = c.Catagories.Where(x => x.CatagoryName == "Meyve").Select(y => y.CatagoryID).FirstOrDefault();
            var FruitCount = c.Foods.Where(x => x.CatagoryID == FruitID).Count();
            ViewBag.FruitCount = FruitCount;
            var VegetableID = c.Catagories.Where(x => x.CatagoryName == "Sebze").Select(y => y.CatagoryID).FirstOrDefault();
            var VegetableCount = c.Foods.Where(x => x.CatagoryID == VegetableID).Count();
            ViewBag.VegetableCount = VegetableCount;
            var Tahil = c.Catagories.Where(x => x.CatagoryID == c.Catagories.Where(x => x.CatagoryName == "Tahıl").Select(y => y.CatagoryID).FirstOrDefault()).Count();
            ViewBag.Tahil = Tahil;

            //  Toplam
            var TotalFood = c.Foods.Sum(x => x.Stock);
            ViewBag.TotalFood = TotalFood;
            var TotalStock = c.Foods.Sum(x => x.price);
            ViewBag.TotalStock = TotalStock;

            // Z den A ya >> Büyükten Küçüğe
            var MaxFood = c.Foods.OrderByDescending(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.MaxFood = MaxFood;
            //  A dan Z ye Küçükten Büyüğe
            var MinFood = c.Foods.OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.MinFood = MinFood;

            //  Ortalama
            var FoodAVG = c.Foods.Average(X => X.price).ToString("0.00");
            ViewBag.FoodAVG = FoodAVG;
            // Bir katagoriye ait ürünlerin tek tek toplanması
            var SumFruidID = c.Catagories.Where(x => x.CatagoryName == "Meyve").Select(y => y.CatagoryID).FirstOrDefault();
            var SumFruid_p = c.Foods.Where(x => x.CatagoryID == SumFruidID).Sum(y => y.Stock);
            ViewBag.SumFruid = SumFruid_p;

            var SumVegetableID = c.Catagories.Where(x => x.CatagoryName == "Sebze").Select(y => y.CatagoryID).FirstOrDefault();
            var SumVegetable = c.Foods.Where(x => x.CatagoryID == SumVegetableID).Sum(y => y.Stock);
            ViewBag.SumVegetable = SumVegetable;

            var MaxPrice = c.Foods.OrderByDescending(x => x.price).Select(y => y.Name).FirstOrDefault();
            ViewBag.MaxPrice = MaxPrice;
            return View();
        }

    }
}
