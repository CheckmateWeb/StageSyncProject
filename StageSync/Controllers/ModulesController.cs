using System.Web.Mvc;

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
    }
}
