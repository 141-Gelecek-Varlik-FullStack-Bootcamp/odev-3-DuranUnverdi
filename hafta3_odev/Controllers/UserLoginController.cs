using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hafta3_odev_Api.Controllers
{
    public class UserLoginController : Controller
    {
        //private readonly Context _context;

        //public UserLoginController(Context context)
        //{
        //    _context = context;
        //}


        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(User p)
        {

            var dataValue = c.Users.FirstOrDefault(x => x.Email == p.Email && x.Password == p.Password);
            if (dataValue != null)
            {
                //var claims = new List<Claim>
                //{
                //    new Claim(ClaimTypes.Name,p.Email)
                //};
                //var userIdentity=new ClaimsIdentity(claims,)


                //Manuel olarak yetki işlemi verdik bunu dinamik bir şekilde authorization işlemi yapılabilir
                var dataValue2 = c.Users.FirstOrDefault(x => "admin@gmail.com" == p.Email && "admin123" == p.Password);
                if (dataValue2 != null)
                {

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("MainPage", "UserLogin");
                }

            }
            else
            {
                return RedirectToAction("Add", "UserRegister");
            }
        }
        public IActionResult MainPage()
        {
            return View();
        }
    }
}

