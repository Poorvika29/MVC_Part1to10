using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("TblEmp")]
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string City { get; set; }
        public string Department { get; set; }


    }
}