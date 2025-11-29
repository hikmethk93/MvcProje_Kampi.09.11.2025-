using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_Kampi.Controllers
{
    public class TestController: Controller
    {
      public ActionResult Index()
        { 
            return View(); 
        }

        public ActionResult SweetAlert()
        {
            return View();
        }
    }
}