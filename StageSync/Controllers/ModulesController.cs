using System.Linq;
using System.Web.Mvc;
using StageSync.Models.Context;

namespace StageSync.Controllers
{
    public class ModulesController : Controller
    {
        public ActionResult LoginPage()
        {
            return View();
        }

        public ActionResult RegistrationPage()
        {
            return View();
        }

        public ActionResult HomePage()
        {

            ViewBag.WelcomeMessage = "Welcome to StageSync — command your show, cue by cue.";
            return View();
        }

        public ActionResult AboutPage()
        {
            return View();
        }

        public ActionResult ContactPage()
        {
            return View();
        }

        // Called from AngularJS via $http for the live status banner on the Home page
        public string GetSystemStatus()
        {
            return "All Systems Operational";
        }

        // ADDED: simple database connection test
        // Open: https://localhost:44393/Modules/DbTest
        public ActionResult DbTest()
        {
            using (var db = new StageSyncContext())
            {
                int types = db.tbl_performer_types.Count();
                int performers = db.tbl_performers.Count();
                return Content("Connected! Performer types: " + types + ", performers: " + performers);
            }
        }

        // ADDED: returns all registered accounts from the database (used by loadAccounts in Controller.js)
        [HttpGet]
        public JsonResult GetAccounts()
        {
            using (var db = new StageSyncContext())
            {
                var list = (from p in db.tbl_performers
                            join t in db.tbl_performer_types on p.typeID equals t.typeID
                            select new
                            {
                                id = p.performerID,
                                username = p.username,
                                firstname = p.firstName,
                                lastname = p.lastName,
                                email = p.email,
                                contactno = p.contactNumber,
                                performertype = t.typeName
                            }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
        }
    }
}