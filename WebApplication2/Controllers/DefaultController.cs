using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int  id)
        {
            ViewBag.id = id;
            employee obj = new employee();
            obj.empid = 1;
            obj.empname = "sai";
            obj.empsal = 3000;
           
            employee obj1 = new employee();

            obj1.empid = 2;
            obj1.empname = "sam";
            obj1.empsal = 4000;

            employee obj2 = new employee();

            obj2.empid = 3;
            obj2.empname = "amit";
            obj2.empsal = 5000;

            List < employee > lemp= new List<employee>();
            lemp.Add(obj);
            lemp.Add(obj1);
            lemp.Add(obj2);

            ViewBag.info = lemp;

            return View();
        }
    }
}