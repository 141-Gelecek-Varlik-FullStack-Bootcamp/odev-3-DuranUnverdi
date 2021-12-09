using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using hafta3_odev_Api.Extension;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hafta3_odev_Api.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ProductManager pm = new ProductManager(new EfProductRepository());
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product p)
        {
            p.ToTurkishConvert();
            pm.TAdd(p);
            return RedirectToAction("Index", "UserLogin");


        }
        public IActionResult GetList()
        {
            var values = pm.GetList();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values = pm.TGetById(id);
            pm.TDelete(values);
            return RedirectToAction("GetList", "Product");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null || id <= 0)
            {
                return BadRequest();
            }
            else
            {
                var productDb = pm.TGetById(id);
                if (productDb == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(productDb);
                }
            }
        }
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            pm.TUpdate(p);
            return RedirectToAction("GetList");
        }
    }
}
