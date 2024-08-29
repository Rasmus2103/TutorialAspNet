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
    [EnableCors(origins: "https://localhost:44325", headers:"*", methods:"*")]
    public class StudentController : ApiController
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "Test",
                Email = "testmail@mail.dk",
                DateOfBirth = new DateTime(1990, 1, 1)
            },
            new Student()
            {
                Id = 2,
                Name = "Test2",
                Email = "testmail2@mail.dk",
                DateOfBirth = new DateTime(1980, 3, 6)
            }
        };
        public IEnumerable<Student> GetStudents() 
        { 
            return students; 
        }
    }
}
