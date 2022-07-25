using CoreAndFoot.Data.Models;
using CoreAndFoot.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace CoreAndFoot.Controllers
{
    public class FoodController : Controller
    {
        Context c = new Context();
        FoodRepository foodRepository = new FoodRepository();

        public IActionResult Index(int page = 1)
        {
            return View(foodRepository.TList("Catagory").ToPagedList(page, 4));
        }

        [HttpGet]
        public IActionResult FoodEkle()
        {
            //List<SelectListItem> degerr = new List<SelectListItem>();
            //foreach (var item in c.Catagories.ToList())
            //{
            //    degerr.Add(new SelectListItem { Text = item.CatagoryName, Value = item.CatagoryID.ToString() });
            //}

            List<SelectListItem> degerr = (from x in c.Catagories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CatagoryName,
                                               Value = x.CatagoryID.ToString()
                                           }).ToList();

            ViewBag.dgrr = degerr;
            return View();
        }
        [HttpPost]
        public IActionResult FoodEkle(UrunEkle p)
        {
            Food f = new Food();
            if (p.ImageUrl != null)
            {

                var ex = Path.GetExtension(p.ImageUrl.FileName);
                var newImageName = Guid.NewGuid() + ex;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resimler/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.ImageUrl.CopyTo(stream);
                f.ImageUrl = newImageName;
            }
            f.Name = p.Name;
            f.price = p.price;
            f.ShortDesc = p.ShortDesc;
            f.Stock = p.Stock;
            f.CatagoryID = p.CatagoryID;
            foodRepository.TAdd(f);
            return RedirectToAction("Index");

            // f.CatagoryID = per;
            //  c.Foods.Add(p);
            //c.SaveChanges();
            //foodRepository.TAdd(p);
        }

        public IActionResult FoodSil(int id)
        {

            foodRepository.TRemove(new Food { FoodID = id });

            return RedirectToAction("Index", "Food");
        }

        [HttpGet]
        public IActionResult FoodGetir(int id)
        {

            var x = foodRepository.getT(id);
            Food f = new Food()
            {
                CatagoryID = x.CatagoryID,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                price = x.price,
                ShortDesc = x.ShortDesc,
                Stock = x.Stock,
                FoodID = x.FoodID
            };

            // List<SelectListItem> foods = new List<SelectListItem>();
            //foreach (var item in c.Catagories.ToList())
            //{
            //    foods.Add(new SelectListItem { Text = item.CatagoryName, Value = item.CatagoryID.ToString() });
            //}
            List<SelectListItem> foods = (from y in c.Catagories.ToList()
                                          select new SelectListItem
                                          {
                                              Text = y.CatagoryName,
                                              Value = y.CatagoryID.ToString()
                                          }).ToList();


            ViewBag.foods = foods;

            return View(f);
        }
        [HttpPost]
        public IActionResult FoodGuncelle( UrunEkle p , IFormCollection form, int id)
        {
            string[] str = form["check"].ToArray();

            var x = foodRepository.getT(id);
            x.Name = p.Name;
            x.price = p.price;
            x.ShortDesc = p.ShortDesc;
            x.Stock = p.Stock;
            x.CatagoryID = p.CatagoryID;


            if (x.ImageUrl != null && str.Length==1 )
            {
                   var ex = Path.GetExtension(p.ImageUrl.FileName);
                   var newImageName = Guid.NewGuid() + ex;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resimler/", newImageName);
                   var stream = new FileStream(location, FileMode.Create);
                    p.ImageUrl.CopyTo(stream);
                    x.ImageUrl = newImageName;
               
            }
            foodRepository.TUpdate(x);
                return RedirectToAction("Index", "Food");
            

        }
    }
}

