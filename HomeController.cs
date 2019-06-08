using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[] {
                new{  EmpId=1, EmpName="Schott", Salary=8000},
                new{  EmpId=2, EmpName="Smith", Salary=18000},
                new{  EmpId=3, EmpName="Allen", Salary=4000},
            };

            string matchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            return Content(matchEmpName, "text/plain");
        }

        /* public  ActionResult GetPaySlip(int EmpId)
         //{
          //   string filename = "~/PaySlip"+ EmpId+ ".pdf";

           //  return File(fileName,"application/pdf");
        */

        public ActionResult EmpFacebookPage(int EmpId)
        {
            var employees = new[] {
                new{  EmpId=1, EmpName="Schott", Salary=8000},
                new{  EmpId=2, EmpName="Smith", Salary=18000},
                new{  EmpId=3, EmpName="Allen", Salary=4000},
            };

            string fbUrl = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    fbUrl = "http://www.facebook.com/emp" + EmpId;
                }
            }
            if (fbUrl == null)
            {
                return Content("invalid emp id");
            }
            else
            {
                return Redirect(fbUrl);
            }

        }
    }

}
       
    