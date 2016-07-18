using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FollowAlongMVC.Models
{
    /// <summary>
    /// This class is mapped to Employee table.
    /// </summary>
    [Table("Employee")]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}