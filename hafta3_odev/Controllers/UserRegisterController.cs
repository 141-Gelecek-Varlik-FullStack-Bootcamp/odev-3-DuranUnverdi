using AutoMapper;
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
    public class UserRegisterController : Controller
    {
        private readonly IMapper _mapper;
        public UserRegisterController(IMapper mapper)
        {
        _mapper=mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        UserManager um = new UserManager(new EfUserRepository());
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User p)
        {
           
                p.Status = 1;
                um.TAdd(p);
                return RedirectToAction("Index", "UserLogin");
        

        }
       
    }
}
