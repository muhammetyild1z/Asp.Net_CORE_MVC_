using CoreAndFoot.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFoot.Data.Models;
using X.PagedList;

namespace CoreAndFoot.Controllers
{
    public class CatagoryController : Controller
    {
        Context c = new Context();
        CatagoryRepository catagoryRepository = new CatagoryRepository();
        public IActionResult Index( string p , int page = 1)
        {
            if (!String.IsNullOrEmpty(p))
            {
                return View(catagoryRepository.List(x=> x.CatagoryName==p).ToPagedList(page, 4));
            }
            return View(catagoryRepository.TList().ToPagedList(page, 4));
            
        }
        [HttpGet]
        public IActionResult KatagoriEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KatagoriEkle( Catagory p)
        {
            if (!ModelState.IsValid)
            {
                return View("KatagoriEkle");
            }
            catagoryRepository.TAdd(p);
            ViewBag.addSuccess = "Katagori Eklendi";
            return RedirectToAction("Index","Catagory");

        }
        public IActionResult KatagoriSil( int id)
        {
            //  catagoryRepository.TRemove(new Catagory { CatagoryID=id});
            var x = catagoryRepository.getT(id);
            x.Status = false;
            catagoryRepository.TUpdate(x);
            return RedirectToAction("Index", "Catagory");
        }
        [HttpGet]
        public IActionResult KatagoriGetir(int id )
        {
            //var cat = c.Catagories.Find(id);
           var cat= catagoryRepository.getT(id);
            return View("KatagoriGetir", cat);
        }
        [HttpPost]
        public IActionResult KatagoriGuncelle(Catagory cat, int id)
        {
            var x = catagoryRepository.getT(id);
            x.CatagoryName = cat.CatagoryName;
            x.CatagoryDesc = cat.CatagoryDesc;
            x.Status = cat.Status;
            catagoryRepository.TUpdate(x);
            return RedirectToAction("Index","Catagory");
        }
    }
}
