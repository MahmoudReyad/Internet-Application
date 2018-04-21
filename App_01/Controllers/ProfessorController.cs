using App_01.Models;
using Models.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace App_01.Controllers
{
    public class ProfessorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Professor
        public ActionResult Index()
        {
            var prof = GetProfesssor();
            return View(prof);
        }


        public IEnumerable <Professor> GetProfesssor ()
        {
            var prof = db.Professors.ToList();
            return prof;
        }



    }
}