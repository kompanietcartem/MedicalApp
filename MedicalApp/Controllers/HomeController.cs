using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicalApp.Models;

namespace MedicalApp.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            MedicalAppContext db = new MedicalAppContext();

            return View(db.Patients);
        }

        public ActionResult GetPatientData(int patientId = 0)
        {
            ViewBag.PatientId = patientId;

            if (patientId == 0)
                return View(new List<Research>());
            
            MedicalAppContext db = new MedicalAppContext();
            
            List<Research> researches = db.Patients.Where(x => x.Id == patientId).Select(x => x.Researches).ToList()[0];

            return View(researches);
        }

        public ActionResult GetResearchData(int patientId = 0, int researchId = 0)
        {
            ViewBag.PatientId = patientId;

            MedicalAppContext db = new MedicalAppContext();
            string info = db.Researches.Where(x => x.Id == researchId).Select(x => x.Description).ToList()[0];

            return View((object)info);
        }
    }
}