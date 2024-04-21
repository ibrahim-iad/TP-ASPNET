using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP1ASP.Models;

namespace TP1ASP.Controllers
{
    public class RectangleController : Controller
    {
        // GET: Rectangle
        public ActionResult Index()
        {
            Rectangle model = new Rectangle();
            return View(model);
        }
        public ActionResult Calculer(Rectangle rect)
        {
            Rectangle model = rect;
            if (ModelState.IsValid)
            {              
                model.Perimetre = 2*(model.Longueur+model.Largeur);
                model.Surface = model.Longueur * model.Largeur;
                return View(model);
            }
            return View("Index", model);
        }
    }
}