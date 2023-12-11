using K2E.DataAcess;
using K2E.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K2E.View.Areas.Admin.Controllers
{
    public class InstructoresController : Controller
    {
        // GET: Admin/Instructores
        public ActionResult Index()
        {
            List<Instructor> List = InstructorDAL.Instance.GetAll();

            return View(List);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Instructor entity)
        {
            InstructorDAL.Instance.Create(entity);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Instructor entity = InstructorDAL.Instance.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(Instructor entity)
        {
            InstructorDAL.Instance.Update(entity);
            return RedirectToAction("Index");
        }
    }
}