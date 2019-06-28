using MusicStoreSites.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreSites.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserService userService;
        public AccountController(IUserService UserService)
        {
            userService = UserService;
        } 
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
    }
}