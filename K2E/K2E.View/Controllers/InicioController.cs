using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using K2E.DataAcess;

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
    }
}