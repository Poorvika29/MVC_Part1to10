using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class EmpController : Controller
    {
        public ActionResult Part_7_EmpDetails()
        { 
              Employee employee = new Employee()
                {
                  EmpID= 1,
                  EmpName = "Poorvi",
                  City = "Hyderabad",
                  Department = "IT"
                };
               return View(employee);
        }

        public ActionResult Part_8_EmpDetails(int id )  // Using Entity Framework
        {
            EmpContext empContext = new EmpContext();
            Employee employee = empContext.Employees.Single(x => x.EmpID == id);
            return View(employee);
        }
        public ActionResult Part_9_EmpDetails()  // Using Entity Framework
        {
            EmpContext empContext = new EmpContext();
            List<Employee> employees = empContext.Employees.ToList();
            return View(employees);
        }
    }
}