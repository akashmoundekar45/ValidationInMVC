using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationInMVC.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please Enter Full Name") ]
        [StringLength(10)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Residential Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Company Profile")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Please Enter Correct Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Current Age")]
        [Range(18,100)]
        public int Age { get; set; }
    }
}