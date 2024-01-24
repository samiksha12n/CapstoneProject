using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapstoneProject.Data;
using CapstoneProject.Models;

namespace CapstoneProject.Controllers
{
    public class AdminsController : Controller
    {
        private CapstoneProjectDbContext db = new CapstoneProjectDbContext();

        // GET: Admins
        public ActionResult Index()
        {
            return View(new AdminInfo());
        }

        // GET: Admins/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminInfo adminInfo = db.AdminInfoes.Find(id);
            if (adminInfo == null)
            {
                return HttpNotFound();
            }
            return View(adminInfo);
        }

        // GET: Admins/Create
        public ActionResult Create()
        {
            return View(new AdminInfo());
        }

        // POST: Admins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmailId,Password")] AdminInfo adminInfo)
        {
            if (ModelState.IsValid)
            {
                db.AdminInfoes.Add(adminInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adminInfo);
        }

        // GET: Admins/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminInfo adminInfo = db.AdminInfoes.Find(id);
            if (adminInfo == null)
            {
                return HttpNotFound();
            }
            return View(adminInfo);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmailId,Password")] AdminInfo adminInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminInfo);
        }

        // GET: Admins/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminInfo adminInfo = db.AdminInfoes.Find(id);
            if (adminInfo == null)
            {
                return HttpNotFound();
            }
            return View(adminInfo);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AdminInfo adminInfo = db.AdminInfoes.Find(id);
            db.AdminInfoes.Remove(adminInfo);
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
