using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sitemaps;

namespace CtsSiteMvc2.Controllers
{
    public class ManufacturingInfosController : Controller
    {
        public ViewResult Index(Models.MenuItem item)
        {
            return View(item.ActionName);
        }

        public static string LocalContollerName { get; private set; } = "Производство";
        [Sitemap]
        [ActionName("Сетка-рабица")]
        public ViewResult Rabitz()
        {
            ViewBag.Message = "Производство сетки рабицы";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("Rabitz");
        }
        [Sitemap]
        [ActionName("Металлоконструкции-и-стеллажи")]
        public ViewResult Metalwork()
        {
            ViewBag.Message = "Металлоконструкции и стелажи";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("Metalwork");
        }
        [Sitemap]
        [ActionName("Мобильные-краны")]
        public ViewResult Cranes()
        {
            ViewBag.Message = "Мобильные краны";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("Cranes");
        }
        [Sitemap]
        [ActionName("Ворота-откатные")]
        public ViewResult SlidingGates()
        {
            ViewBag.Message = "Ворота откатные";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("SlidingGates");
        }
        [Sitemap]
        [ActionName("Ворота-распашные")]
        public ViewResult SwingGates()
        {
            ViewBag.Message = "Ворота распашные";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("SwingGates");
        }
        [Sitemap]
        [ActionName("Заборы")]
        public ViewResult Fences()
        {
            ViewBag.Message = "Заборы";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("Fences");
        }
        [Sitemap]
        [ActionName("Калитки")]
        public ViewResult Wickets()
        {
            ViewBag.Message = "Калитки";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("Wickets");
        }
        [Sitemap]
        [ActionName("Мангалы-грили-беседки")]
        public ViewResult Others()
        {
            ViewBag.Message = "Мангалы, грили, беседки";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("Others");
        }
        [Sitemap]
        [ActionName("Цветной-щебень")]
        public ViewResult ColoredGravel()
        {
            ViewBag.Message = "Цветной щебень";
            ViewBag.MetaSeoTeg = ViewBag.Message;
            ViewBag.Title = ViewBag.Message;
            return View("ColoredGravel");
        }
    }
}