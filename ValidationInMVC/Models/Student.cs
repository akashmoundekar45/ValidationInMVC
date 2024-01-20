using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidationInMVC.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Please Enter Full Name of Student")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please Enter Residential Permanent Address of Student")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Email of Student")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Mobile of Student")]
        [MaxLength(10)]
        [MinLength(10)]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please Enter Present Age of Student")]
        [Range(18,100)]
        public int Age { get; set; }

    }
}