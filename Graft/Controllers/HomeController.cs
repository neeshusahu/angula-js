using Graft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Graft.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Get(Details d)
        {
            List<Details> d1 = new List<Details>();
            if(d.id==1)
            {
                d.name = "neeshu";
                

         
            }
            else
            {
                d.name = "Keshu";

            }
            d1.Add(d);
            return PartialView(d1);

        }

    }
}