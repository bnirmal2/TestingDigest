using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingDigest;

namespace Index.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult About(string FirstName)
        {
            InsertIntoDataBase(FirstName);

            return View();
        }

        private void InsertIntoDataBase(string FirstName)
        {
            using (var testdb = new ModeltestContainer())
            {
                var test = testdb.Tests.Create();
                test.FirstName = FirstName;
                test.Email = "sdsds";
                test.LastName = "sadsdsa";
                test.Password = "asas";
                testdb.Tests.Add(test);

                testdb.SaveChanges();

            }



        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}