using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TEST01.Models;

namespace TEST01.Controllers
{
    public class TrucksController : Controller
    {
        private TestProject1Entities db = new TestProject1Entities();

        // GET: Trucks
        public ActionResult Index()
        {
            var trucks = db.Trucks.Include(t => t.Garage);
            return View(trucks.ToList());
        }

        // GET: Trucks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Truck truck = db.Trucks.Find(id);
            if (truck == null)
            {
                return HttpNotFound();
            }
            return View(truck);
        }

        // GET: Trucks/Create
        public ActionResult Create()
        {
            ViewBag.GarageID = new SelectList(db.Garages, "GarageID", "GarageAddress");
            return View();
        }

        // POST: Trucks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TruckNumber,VinNumber,LiscencePlate,TruckStatus,Chassis,TruckPower,Torque,GearBox,TankCapacity,MaxLoad,PreferredLoad,MakeAndModel,GarageID")] Truck truck)
        {
            if (ModelState.IsValid)
            {
                db.Trucks.Add(truck);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GarageID = new SelectList(db.Garages, "GarageID", "GarageAddress", truck.GarageID);
            return View(truck);
        }

        // GET: Trucks/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Truck truck = db.Trucks.Find(id);
            if (truck == null)
            {
                return HttpNotFound();
            }
            ViewBag.GarageID = new SelectList(db.Garages, "GarageID", "GarageAddress", truck.GarageID);
            return View(truck);
        }

        // POST: Trucks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TruckNumber,VinNumber,LiscencePlate,TruckStatus,Chassis,TruckPower,Torque,GearBox,TankCapacity,MaxLoad,PreferredLoad,MakeAndModel,GarageID")] Truck truck)
        {
            if (ModelState.IsValid)
            {
                db.Entry(truck).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GarageID = new SelectList(db.Garages, "GarageID", "GarageAddress", truck.GarageID);
            return View(truck);
        }

        // GET: Trucks/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Truck truck = db.Trucks.Find(id);
            if (truck == null)
            {
                return HttpNotFound();
            }
            return View(truck);
        }

        // POST: Trucks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Truck truck = db.Trucks.Find(id);
            db.Trucks.Remove(truck);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
