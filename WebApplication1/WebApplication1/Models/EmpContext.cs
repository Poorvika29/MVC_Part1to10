﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class EmpContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}