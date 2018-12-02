using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReggaetonDale.Controllers
{
    public class CadastrosController : Controller
    {
        // GET: Cadastros
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Carreira()
        {
            return View("Carreira");
        }

        public ActionResult UsuarioCarreira()
        {
            return View("UsuarioCarreira");
        }

    }
}