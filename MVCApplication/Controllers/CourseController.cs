using MVCApplication.DataAccess;
using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class CourseController : Controller
    {
        private RouxAcademyDBContext db = new RouxAcademyDBContext();

        // GET: Course
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Online()
        {
            //var courses = db.Courses.Where(c => c.IsVirtual)
            //                        .OrderBy(c => c.Name)
            //                        .ToList();

            var courses = from c in db.Courses
                          where c.IsVirtual 
                          orderby c.Name
                          select c;

            return View(courses.ToList());
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            var course = db.Courses.Where(c => c.Id == id).SingleOrDefault();

            return View(course);
        }


        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(Course course)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    using(var context = new RouxAcademyDBContext())
                    {
                        context.Courses.Add(course);
                        context.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return View(course);
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Review() 
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Review(CourseReview review)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(review);
        }
    }
}
