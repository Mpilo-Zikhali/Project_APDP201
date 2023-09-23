using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Medical_Centre.proj.Models;

namespace Medical_Centre.proj.Controllers
{
    public class ForgotPasswordController : Controller
    {
        private MedicalCentreContext db = new MedicalCentreContext();

        // GET: ForgotPassword
        public async Task<ActionResult> Index()
        {
            return View(await db.PatientDetails.ToListAsync());
        }

        // GET: ForgotPassword/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetails patientDetails = await db.PatientDetails.FindAsync(id);
            if (patientDetails == null)
            {
                return HttpNotFound();
            }
            return View(patientDetails);
        }

        // GET: ForgotPassword/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ForgotPassword/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SNumber,Role,Name,Surname,gender,Email,PhoneNumber,University,Cillness,CreatePassword,ConfirmPassword")] PatientDetails patientDetails)
        {
            if (ModelState.IsValid)
            {
                db.PatientDetails.Add(patientDetails);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(patientDetails);
        }

        // GET: ForgotPassword/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetails patientDetails = await db.PatientDetails.FindAsync(id);
            if (patientDetails == null)
            {
                return HttpNotFound();
            }
            return View(patientDetails);
        }

        // POST: ForgotPassword/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SNumber,Role,Name,Surname,gender,Email,PhoneNumber,University,Cillness,CreatePassword,ConfirmPassword")] PatientDetails patientDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientDetails).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(patientDetails);
        }

        // GET: ForgotPassword/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientDetails patientDetails = await db.PatientDetails.FindAsync(id);
            if (patientDetails == null)
            {
                return HttpNotFound();
            }
            return View(patientDetails);
        }

        // POST: ForgotPassword/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            PatientDetails patientDetails = await db.PatientDetails.FindAsync(id);
            db.PatientDetails.Remove(patientDetails);
            await db.SaveChangesAsync();
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
