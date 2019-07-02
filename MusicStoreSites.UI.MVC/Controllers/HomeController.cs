using MusicStoreSites.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreSites.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IAlbumService albumService;
        IGenreService genreService;
        public HomeController(IAlbumService album, IGenreService genre)
        {
            albumService = album;
            genreService = genre;
        }
        [Route("Home")]
        public ActionResult Index()
        {
            return View(albumService.GetAll());
        }
        [Route("_GenreMenu")]
        public ActionResult _GenreMenu()
        {
            return PartialView(genreService.GetAll());
        }
        [Route("_GenreOfAlbums")]
        public ActionResult _GenreOfAlbums(int? id)
        {
            if(id!=null)
            {
                return PartialView(albumService.GetAlbumsOfGenre(id.Value).ToList());
            }
            return PartialView(albumService.GetAll());
        }
        [Route("_DiscontinuedAlbums")]
        public ActionResult _DiscontinuedAlbums()
        {
            var urunler = albumService.GetDiscontinuedAlbums().ToList();
            if(urunler.Count==0)
            {
                ViewBag.Error = "İndirimde ürün bulunmamaktadır.";
                return PartialView();
            }
            return PartialView(urunler);
        }
        [Route("_LastFiveAlbums")]

        public ActionResult _LastFiveAlbums()
        {
            return PartialView(albumService.GetLastFiveAlbums());
        }
    }
}