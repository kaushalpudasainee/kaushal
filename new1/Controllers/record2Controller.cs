using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using new1.Models;

namespace new1.Controllers
{
    public class record2Controller : Controller
    {
        catEntities db = new catEntities();

        // GET: record2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            List<record2> all_data = db.record2.ToList();
            return View();
        }
        public ActionResult SaveData(new1.Models.record2 record2)

        {
            db.record2.Add(record2);
            db.SaveChanges();
            return RedirectToAction("kaushal");
        }
        public ActionResult Edit(int id)
        {
            record2 data = db.record2.Find(id);
            //record2 data = db.employee.FirstorDefault(x=)
            return View(data);
        }
        public ActionResult UpdateData(record2 record2)
        {
            record1 update = db.record1.Find(record2.id);
            update.name = record2.name;
            update.address = record2.address;
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("kaushal");

        }

    }
}