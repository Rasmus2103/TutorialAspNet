using RouxAcademyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RouxAcademyAPI.Controllers
{
    [EnableCors(origins: "https://localhost:44325", headers: "*", methods: "*")]
    public class CourseController : ApiController
    {
        List<Course> courses = new List<Course>()
        {
            new Course()
            {
                Id = 1,
                Title = "Introduction to Programming",
                Description = "Learn the basics of programming with C#.",
                IsActive = true
            },
            new Course()
            {
                Id = 2,
                Title = "Advanced Databases",
                Description = "Explore advanced topics in database management systems.",
                IsActive = false
            },
            new Course()
            {
                Id = 3,
                Title = "Web Development with ASP.NET",
                Description = "Develop dynamic web applications using ASP.NET Core.",
                IsActive = true
            }
        };

        public IEnumerable<Course> GetCourses()
        {
            return courses;
        }
    }
}
