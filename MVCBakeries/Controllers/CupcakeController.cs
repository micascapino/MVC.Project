using MVCBakeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBakeries.Controllers
{
    public class CupcakeController : Controller
    {
        private BakeryContext context = new BakeryContext();
        // GET: Cupcake
        public ActionResult Index()
        {
            List<Cupcake> lista = context.Cupcakes.ToList();
            return View("Index",lista);
        }
        public ActionResult Create()
        {
            Cupcake newCupcake = new Cupcake();
            return View("Create", newCupcake);
        }

        [HttpPost]
        public ActionResult Create(Cupcake cupcake)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", cupcake);
            }
            context.Cupcakes.Add(cupcake);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Cupcake cupcake = context.Cupcakes.Find(id);
            if (cupcake == null)
            {
                return HttpNotFound();
            }
            return View("Delete", cupcake);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cupcake cupcake = context.Cupcakes.Find(id);
            context.Cupcakes.Remove(cupcake);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Cupcake cupcake = context.Cupcakes.Find(id);
            return View("Details", cupcake);
        }

    }
}