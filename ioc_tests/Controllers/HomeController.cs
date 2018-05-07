using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ioc_tests.Controllers
{
    public class HomeController : Controller
    {
        ICar _car;

       public  HomeController(ICar car)
        {
            _car = car;
        }


        // GET: Home
        public ActionResult Index()
        {
            ViewBag.car = _car.velocity();

            return View(_car);
        }
    }
}