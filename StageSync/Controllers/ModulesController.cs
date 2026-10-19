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
            // Controller -> Welcome Message -> View
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
    }
}