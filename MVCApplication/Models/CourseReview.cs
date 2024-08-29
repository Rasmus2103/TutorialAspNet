using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCApplication.Models
{
    public class CourseReview
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string courseName { get; set; }

        [Required]
        [Display(Name = "Review Comments")]
        [StringLength(100)]
        public string comments { get; set; }

        [Display(Name = "Do you recommend this course?")]
        public bool recommended { get; set; }
    }
}