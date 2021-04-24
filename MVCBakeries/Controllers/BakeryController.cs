using MVCBakeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBakeries.Controllers
{
    public class BakeryController : Controller
    {
        private BakeryContext context = new BakeryContext();

        // GET: Bakery
        public ActionResult Index()
        {
            List<Bakery> lista = context.Bakeries.ToList();
            return View(lista);
        }

        public ActionResult Create()
        {
            Bakery newBakery = new Bakery();
            return View("Create", newBakery);
        }

        [HttpPost]
        public ActionResult Create(Bakery bakery)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", bakery);
            }
            context.Bakeries.Add(bakery);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}