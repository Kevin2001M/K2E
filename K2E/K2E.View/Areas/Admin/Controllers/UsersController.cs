using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K2E.Entities;
using K2E.DataAcess;

namespace K2E.View.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            List<User> List = UserDAL.Instance.GetAll();

            return View(List);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(User entity)
        {
 
            UserDAL.Instance.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            User entity = UserDAL.Instance.GetById(id);
            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(User entity)
        {
            UserDAL.Instance.Update(entity);
            return RedirectToAction("Index");
        }

    }
}