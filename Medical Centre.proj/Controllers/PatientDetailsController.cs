using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Medical_Centre.proj.Models;

namespace Medical_Centre.proj.Controllers
{
    public class PatientDetailsController : Controller
    {
        private MedicalCentreContext db = new MedicalCentreContext();

        // GET: PatientDetails
        public ActionResult Index()
        {
            return View(db.PatientDetails.ToList());
        }

        // GET: PatientDetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetails patientDetails = db.PatientDetails.Find(id);
            if (patientDetails == null)
            {
                return HttpNotFound();
            }
            return View(patientDetails);
        }

        public ActionResult login()
        {
            return View();
        }

        // GET: PatientDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SNumber,Role,Name,Surname,gender,Email,PhoneNumber,University,Cillness,CreatePassword,ConfirmPassword")] PatientDetails patientDetails)
        {
            if (ModelState.IsValid)
            {
                db.PatientDetails.Add(patientDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientDetails);
        }

        // GET: PatientDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetails patientDetails = db.PatientDetails.Find(id);
            if (patientDetails == null)
            {
                return HttpNotFound();
            }
            return View(patientDetails);
        }

        // POST: PatientDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SNumber,Role,Name,Surname,gender,Email,PhoneNumber,University,Cillness,CreatePassword,ConfirmPassword")] PatientDetails patientDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientDetails);
        }

        // GET: PatientDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetails patientDetails = db.PatientDetails.Find(id);
            if (patientDetails == null)
            {
                return HttpNotFound();
            }
            return View(patientDetails);
        }

        // POST: PatientDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PatientDetails patientDetails = db.PatientDetails.Find(id);
            db.PatientDetails.Remove(patientDetails);
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
