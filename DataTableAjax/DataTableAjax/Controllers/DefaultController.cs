using DataTableAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTableAjax.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public static object getUser()
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario(1, "Jorge", "456"));
            lista.Add(new Usuario(2, "Amelia", "741"));
            lista.Add(new Usuario(3, "Geovanny", "9863"));
            lista.Add(new Usuario(4, "Petter", "423"));
            lista.Add(new Usuario(5, "Ríos", "758"));
            lista.Add(new Usuario(6, "Ñato", "123"));

            object json = new { data = lista };

            return json;
        }
    }
}