using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CtsSiteMvc2.Models;
using Sitemaps;

namespace CtsSiteMvc2.Controllers
{
    public class HomeController : Controller
    {
        [Sitemap(Frequency = SitemapFrequency.Daily, Priority = 1.0)]
        public ActionResult Index()
        {
            return View("Index", new Menu());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Sitemap(Frequency = SitemapFrequency.Weekly)]
        [ActionName("Контакты")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Как с нами связаться:";

            return View("Contact");
        }

        [ActionName("_SlideMenu")]
        [ChildActionOnly]
        public ActionResult SlideMenu()
        {
            Menu menu = new Menu { Id = 1, Name = "SlideMenu" };
            var items = new[]
            {
                    new MenuItem
                    {
                         Name = "Металлоконструкции и стеллажи",
                         ParentMenu= menu,
                         ControllerName=ManufacturingInfosController.LocalContollerName, //nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Металлоконструкции-и-стеллажи",
                    },
                    new MenuItem
                    {
                         Name = "Цветной щебень",
                         ParentMenu= menu,
                         ControllerName=ManufacturingInfosController.LocalContollerName,//nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Цветной-щебень",
                    },

                    new MenuItem
                    {
                        Name = "Ворота откатные",
                        ParentMenu = menu,
                        ControllerName=ManufacturingInfosController.LocalContollerName,//nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Ворота-откатные",
                    },

                    new MenuItem
                    {
                        Name="Мобильные краны",
                        ParentMenu = menu,
                        ControllerName=ManufacturingInfosController.LocalContollerName,//nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Мобильные-краны",
                    },



                    new MenuItem
                    {
                         Name = "Ворота распашные",
                         ParentMenu= menu,
                         ControllerName=ManufacturingInfosController.LocalContollerName,//nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Ворота-распашные",
                    },

                    new MenuItem
                    {
                         Name = "Заборы",
                         ParentMenu= menu,
                         ControllerName=ManufacturingInfosController.LocalContollerName,//nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Заборы",
                    },

                    new MenuItem
                    {
                         Name = "Производство сетки рабицы",
                         ParentMenu = menu,
                         ControllerName=ManufacturingInfosController.LocalContollerName,//nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Сетка-рабица",
                    },

                    new MenuItem
                    {
                         Name = "Калитки",
                         ParentMenu= menu,
                         ControllerName=ManufacturingInfosController.LocalContollerName,//nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Калитки",
                    },



                    new MenuItem
                    {
                         Name = "Мангалы, грили, беседки",
                         ParentMenu= menu,
                         ControllerName=ManufacturingInfosController.LocalContollerName,//nameof(ManufacturingInfosController).Replace("Controller", ""),
                         ActionName = "Мангалы-грили-беседки",
                    }
            };

            string action = ControllerContext.ParentActionViewContext.RouteData.Values["action"].ToString();
            string controller = ControllerContext.ParentActionViewContext.RouteData.Values["controller"].ToString();

            /*var currentItem = items.FirstOrDefault(item => item.ControllerName == controller && item.ActionName == action);*/
            var currentItem = items.FirstOrDefault(item => nameof(ManufacturingInfosController).Replace("Controller", "") == controller  && item.ActionName == action);
            if (currentItem != null)
                currentItem.IsSelected = true;

            return PartialView("_SlideMenu", items);
        }

        //[ChildActionOnly]
        public ActionResult ImageGallery()
        {
            return View("ImageGallery");
        }

        public ActionResult Disqus()
        {
            return View("Disqus");
        }

    }
}