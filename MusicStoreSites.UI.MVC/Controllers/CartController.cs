using MusicStoreSites.BLL.Abstract;
using MusicStoreSites.UI.MVC.CustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreSites.UI.MVC.Controllers
{
    public class CartController : Controller
    {
        IAlbumService albumService;
        public CartController(IAlbumService AlbumService)
        {
            albumService = AlbumService;
        }

        [CustomFilter]
        [Route("Cart")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("_CartList")]
        public ActionResult _CartList()
        {
            return PartialView();
        }
    }
}