using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FollowAlongMVC.Models
{
    /// <summary>
    /// Establishes connection to database
    /// </summary>
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> EmployeeSet { get; set; }
    }
}