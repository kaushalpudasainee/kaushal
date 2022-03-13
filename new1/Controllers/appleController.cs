using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using new1.Views;

namespace new1.Controllers
{
    public class appleController : Controller
    {
        catEntities db = new Views.catEntities();

        // GET: apple
        public ActionResult kaushal()
        {
            List<record1> all_data = db.record1.ToList();
            return View(all_data );
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(record1 record1)
        {
            db.record1.Add(record1);
            db.SaveChanges();
            return RedirectToAction("kaushal");
        }
    }
}