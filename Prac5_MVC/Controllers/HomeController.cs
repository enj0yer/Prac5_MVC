using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Prac5_MVC.Controllers
{
    public class HomeController : Controller
    {
        private static DataTable Table { get; } = new DataTable();

        private static double Calculate(string Expression)
        {
            return Convert.ToDouble(Table.Compute(Expression, string.Empty));
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string CalcString)
        {
            bool error = false;
            string result = "";

            try
            {
                result = Calculate(CalcString).ToString();
            }
            catch
            {
                error = true;
            }

            if (error || result == "∞" || result == "-∞" || result == "не число")
            {
                result = "Ошибка в вычислениях";
            }
            ViewData["result"] = result;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}