using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using K2E.DataAcess;
using K2E.Entities;

namespace K2E.View.Controllers
{
    public class InicioController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            var list = CategoryDAL.Instance.GetAll();
            return View(list);
        }



        public ActionResult MostrarCursos()
        {
            var list = CourseDAL.Instance.GetAll();
            return View(list);
        }

        public ActionResult MostrarInstructores()
        {
            var list = InstructorDAL.Instance.GetAll();
            return View(list);
        }


        [HttpGet]
        public ActionResult VerMas(int id)
        {
           List<Course> entity = CourseDAL.Instance.GetAllByCategory(id);

            return View(entity);
        }


        public ActionResult Inicio()
        {            
            return View();
        }


    }


}