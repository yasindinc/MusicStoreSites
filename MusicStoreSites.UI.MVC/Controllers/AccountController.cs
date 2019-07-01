using MusicStoreSites.BLL.Abstract;
using MusicStoreSites.Model;
using MusicStoreSites.UI.MVC.Tools;
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
        [Route("Register")]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public ActionResult Register(User user)
        {
            try
            {
                userService.Insert(user);
                bool sonuc = MailHelper.SendConfirmationMail(user.UserName, user.Password, user.Email, user.ID);
                if(!sonuc)
                {
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Veritabanı ekleme hatası!";
                return View();
            }
            return RedirectToAction("Login", "Account");
        }
        [HttpGet]
        [Route("Login")]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Login")]
        public ActionResult Login(User user)
        {
            var gelenKullanici = userService.GetUserByLogin(user.UserName, user.Password);
            if(gelenKullanici!=null)
            {
                Session["kullanici"] = gelenKullanici;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Kullanıcı Bulunamadı";
            return View();
        }

    }
}