using K2E.DataAcess;
using K2E.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
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

            //lista desplegable de categoría
            // Obtener las categorías para la lista desplegable
            List<Category> categorias = CategoryDAL.Instance.GetAll();

            // Crear una lista de objetos SelectListItem especificando tanto el valor como el texto
            var selectCategoryListItems = categorias.Select(c => new SelectListItem
            {
                Value = c.CategoryId.ToString(), // Asignar el valor deseado
                Text = c.Nombre  // Concatenar el texto deseado
            }).ToList();

            // Puedes pasar las categorías al modelo de la vista
            ViewBag.Categorias = new SelectList(selectCategoryListItems, "Value", "Text");

            //Lista desplegable de instructores
            // Obtener las categorías para la lista desplegable
            List<Instructor> instructors = InstructorDAL.Instance.GetAll();
           
            // Crear una lista de objetos SelectListItem especificando tanto el valor como el texto
            var selectInstructorListItems = instructors.Select(i => new SelectListItem
            {
                Value = i.InstructorId.ToString(), // Asignar el valor deseado
                Text = i.Nombre +", "+i.TituloEspecialidad // Concatenar el texto deseado
            }).ToList();

            // Puedes pasar las categorías al modelo de la vista
            ViewBag.Instructors = new SelectList(selectInstructorListItems, "Value", "Text");

            return View();
        }

        [HttpPost]
        public ActionResult Create(Course entity)
        {
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
            entity.FechaPublicacion = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            CourseDAL.Instance.Create(entity);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Course entity = CourseDAL.Instance.GetById(id);
            //lista desplegable de categoría
            // Obtener las categorías para la lista desplegable
            List<Category> categorias = CategoryDAL.Instance.GetAll();

            // Crear una lista de objetos SelectListItem especificando tanto el valor como el texto
            var selectCategoryListItems = categorias.Select(c => new SelectListItem
            {
                Value = c.CategoryId.ToString(), // Asignar el valor deseado
                Text = c.Nombre  // Concatenar el texto deseado
            }).ToList();

            // Puedes pasar las categorías al modelo de la vista
            ViewBag.Categorias = new SelectList(selectCategoryListItems, "Value", "Text");

            //Lista desplegable de instructores
            // Obtener las categorías para la lista desplegable
            List<Instructor> instructors = InstructorDAL.Instance.GetAll();

            // Crear una lista de objetos SelectListItem especificando tanto el valor como el texto
            var selectInstructorListItems = instructors.Select(i => new SelectListItem
            {
                Value = i.InstructorId.ToString(), // Asignar el valor deseado
                Text = i.Nombre + ", " + i.TituloEspecialidad // Concatenar el texto deseado
            }).ToList();

            // Puedes pasar las categorías al modelo de la vista
            ViewBag.Instructors = new SelectList(selectInstructorListItems, "Value", "Text");

            return View(entity);
        }

        [HttpPost]
        public ActionResult Edit(Course entity)
        {
            string fechaFormateada = entity.FechaPublicacion.ToString("yyyy-MM-dd");
            entity.FechaPublicacion = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            CourseDAL.Instance.Update(entity);
            return RedirectToAction("Index");
        }
    }
}