using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MIW4200_940.DAL;
using MIW4200_940.Models;

namespace MIW4200_940.Controllers
{
    public class LineItemsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: LineItems
        public ActionResult Index()
        {
            var lineItem = db.lineItem.Include(l => l.orders).Include(l => l.product);
            return View(lineItem.ToList());
        }

        // GET: LineItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineItem lineItem = db.lineItem.Find(id);
            if (lineItem == null)
            {
                return HttpNotFound();
            }
            return View(lineItem);
        }

        // GET: LineItems/Create
        public ActionResult Create()
        {
            ViewBag.ordersID = new SelectList(db.orders, "ordersID", "description");
            ViewBag.productID = new SelectList(db.product, "productID", "description");
            return View();
        }

        // POST: LineItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "lineitemID,qtyOrdered,price,productID,ordersID")] LineItem lineItem)
        {
            if (ModelState.IsValid)
            {
                db.lineItem.Add(lineItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ordersID = new SelectList(db.orders, "ordersID", "description", lineItem.ordersID);
            ViewBag.productID = new SelectList(db.product, "productID", "description", lineItem.productID);
            return View(lineItem);
        }

        // GET: LineItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineItem lineItem = db.lineItem.Find(id);
            if (lineItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.ordersID = new SelectList(db.orders, "ordersID", "description", lineItem.ordersID);
            ViewBag.productID = new SelectList(db.product, "productID", "description", lineItem.productID);
            return View(lineItem);
        }

        // POST: LineItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "lineitemID,qtyOrdered,price,productID,ordersID")] LineItem lineItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lineItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ordersID = new SelectList(db.orders, "ordersID", "description", lineItem.ordersID);
            ViewBag.productID = new SelectList(db.product, "productID", "description", lineItem.productID);
            return View(lineItem);
        }

        // GET: LineItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineItem lineItem = db.lineItem.Find(id);
            if (lineItem == null)
            {
                return HttpNotFound();
            }
            return View(lineItem);
        }

        // POST: LineItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LineItem lineItem = db.lineItem.Find(id);
            db.lineItem.Remove(lineItem);
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
