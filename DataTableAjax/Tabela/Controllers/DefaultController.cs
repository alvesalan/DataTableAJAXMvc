using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tabela.Context;
using Tabela.Models;

namespace Tabela.Controllers
{
    public class DefaultController : Controller
    {
    DBContext db = new DBContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult loaddata()
        {
            using (db)
            {
                var data = db.usuarios.OrderBy(a => a.Nome).ToList();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);
               
            }
        }
    }
}