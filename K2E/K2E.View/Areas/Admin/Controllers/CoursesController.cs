using K2E.DataAcess;
using K2E.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K2E.View.Areas.Admin.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Admin/Courses
        public ActionResult Index()
        {
            List<Course> List = CourseDAL.Instance.GetAll();

            return View(List);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Course entity)
        {
            CourseDAL.Instance.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Course entity = CourseDAL.Instance.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(Course entity)
        {
            CourseDAL.Instance.Update(entity);
            return RedirectToAction("Index");
        }
    }
}