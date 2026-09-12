using _3ITD_StageSync.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace _3ITD_StageSync.Controllers
{
    public class ModuleController : Controller
    {

        public ActionResult LoginPage()
        {
            return View();
        }


        public ActionResult HomePage()
        {
            return View();
        }


        public ActionResult RegistrationPage()
        {
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

        public string GetUsername()
        {
            return "Mariveles";
        }


        public string UpdateUsername(string username)
        {

            var updated_username = username + "-" + "updated";
            return updated_username;
        }


        public JsonResult UserVerification(UserModel umodel)
        {
            try
            {
                return Json(new { success = true, data = umodel }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message;
                var errorInnerException = ex.InnerException;
                var errorStack = ex.StackTrace;

                return Json(new { success = false, message = errorMessage }, JsonRequestBehavior.AllowGet);
            }
        }

        public void Setusername(string username)
        {
            // Set the username logic here
        }
    }
}