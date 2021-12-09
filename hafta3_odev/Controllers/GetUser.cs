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
    public class GetUser : Controller
    {
        private readonly IMapper _mapper;
        public GetUser(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        UserManager udm = new UserManager(new EfUserRepository());
        [HttpGet]
        public IActionResult Index(User user)
        {
            var userInfo = udm.GetList();
            var mappedItem = _mapper.Map<List<UserDto>>(userInfo);
            return View(mappedItem);
        }
     
    }
}
