using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BensPersonalSite.Controllers
{
    public class ErrorController : Controller
    {
        private const int NotFoundCode = 404;
        private const int InternalErrorCode = 500;

        public ActionResult NotFound()
        {
            Response.StatusCode = NotFoundCode;
            
            return View();
        }

        public ActionResult InternalError()
        {
            Response.StatusCode = InternalErrorCode;

            return View();
        }
    }
}