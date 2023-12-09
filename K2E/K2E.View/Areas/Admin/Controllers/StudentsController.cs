using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K2E.Entities;
using K2E.DataAcess;

namespace K2E.View.Areas.Admin.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Admin/Students
        public ActionResult Index()
        {
            List<Student> List = StudentDAL.Instance.GetAll();

            return View(List);  
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student entity)
        {
            StudentDAL.Instance.Create(entity);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student entity = StudentDAL.Instance.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(Student entity)
        {
            StudentDAL.Instance.Update(entity);
            return RedirectToAction("Index");
        }

    }
}