using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class Course
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Display(Name = "Online Course")]
        public bool IsVirtual { get; set; }
    }
}