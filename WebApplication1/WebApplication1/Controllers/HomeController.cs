using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello MVC";
        }

        public string GetDetails(string id, string name) //Part 4
        {
            return "Hello GetDetails  Id = " + id + "  Name =" + name;
        }
        public string GetDetails1(string id) //Part 4     
        {
            return "Id  = " + id + "" + Request.QueryString["name"];
        }

         public List<string> Part_5()
         {
             return new List<string>()
                    {
                     "India",
                     "Us",
                     "UK",
                     "Canada"
                     };
         }

        public ActionResult Part_5_Views() // Part 5 ViewBag
        {
             ViewBag.Countries = new List<string>()
                    {
                     "India",
                     "Us",
                     "UK",
                     "Canada"
                     };
            return View();
        }
        public ActionResult Part_6_ViewData() // Part 6 ViewData
        {
            ViewData["Countries"] = new List<string>()
                    {
                     "India",
                     "Us",
                     "UK",
                     "Canada"
                     };
            return View();
        }
    }
}