using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookDemo.Models;
using Microsoft.AspNetCore.Http;

namespace BookDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // return Redirect("Books");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            //string cookieVal = Request.Cookies["ZipCode"];
            //if (cookieVal == null)
            //{
            //    // cookie with name "ZipCode" doesn’t exist
            //    Response.Cookies.Append("ZipCode", "08205");
            //}
            //else
            //{
            //    // cookie exists, can use cookieVal
            //    cookieVal = cookieVal + "-9441";
            //    CookieOptions expires = new CookieOptions
            //    {
            //        Expires = DateTime.Now.AddYears(1)
            //    };

            //    Response.Cookies.Append("ZipCode", cookieVal, expires);

            //}



            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
          //  Response.Cookies.Delete("ZipCode");
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
