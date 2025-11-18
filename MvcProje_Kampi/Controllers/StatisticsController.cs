using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_Kampi.Controllers
{
    public class StatisticsController : Controller
    {
        StatisticsManager sm = new StatisticsManager(new EfStatisticsDal());
        public ActionResult Index()
        {
            var StatisticsValues = sm.GetList();
            return View(StatisticsValues);
        }


    }
}


