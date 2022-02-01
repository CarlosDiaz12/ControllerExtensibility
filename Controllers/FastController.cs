using ControllerExtensibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace ControllerExtensibility.Controllers
{
    // Using the SessionState Attribute
    // Disable session for the controller
    [SessionState(SessionStateBehavior.Disabled)]
    public class FastController : Controller
    {
        // GET: Fast
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Fast ",
                ActionName = "Index"
            });
        }
    }
}