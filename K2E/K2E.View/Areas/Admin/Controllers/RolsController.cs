using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K2E.Entities;
using K2E.DataAcess;

namespace K2E.View.Areas.Admin.Controllers
{
    public class RolsController : Controller
    {
        // GET: Admin/Rols
        public ActionResult Index()
        {
            List<Rol> List = RolDAL.Instance.GetAll();

            return View(List);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Rol entity)
        {
            RolDAL.Instance.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Rol entity = RolDAL.Instance.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(Rol entity)
        {
            RolDAL.Instance.Update(entity);
            return RedirectToAction("Index");
        }

    }
}