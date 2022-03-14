using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using new1.Models;

namespace new1.Controllers
{
    public class appleController : Controller
    {
        catEntities db = new catEntities();

        // GET: apple
        public ActionResult kaushal()
        {
            List<record1> all_data = db.record1.ToList();
            return View(all_data);
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
        public ActionResult Edit(int id)
        {
            record1 data = db.record1.Find(id);
            //record1 data = db.employee.FirstorDefault(x=)
            return View(data);
        }
        public ActionResult UpdateData(record1 record1)
        {
            record1 update = db.record1.Find(record1.id);
            update.name = record1.name;
            update.address = record1.address;
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("kaushal");

        }

    }
}
