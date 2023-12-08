using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K2E.Entities;
using K2E.DataAcess;

namespace K2E.View.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            List<Category> List = CategoryDAL.Instance.GetAll();

            return View(List);
        }

        [HttpGet]
        public ActionResult Create() {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Category entity)
        {
            CategoryDAL.Instance.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category entity = CategoryDAL.Instance.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(Category entity)
        {
            CategoryDAL.Instance.Update(entity);
            return RedirectToAction("Index");
        }

    }
}