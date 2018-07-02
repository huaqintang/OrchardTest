using Orchard.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalTest.Products.Controllers
{
    [Themed]
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        //Women
        public ActionResult WomenIndex()
        {
            return View();
        }

        //Men
        public ActionResult MenIndex()
        {
            return View();
        }

    }
}