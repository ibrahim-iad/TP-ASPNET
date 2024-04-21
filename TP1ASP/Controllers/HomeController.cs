using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP1ASP.Models;

namespace TP1ASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Table(int id)
        {
            ViewBag.nombre = id;
            return View();
        }
        public ActionResult Table2(int id)
        {            
            return View(id);
        }
        public ActionResult Table3(int id)
        {
            List<LigneTableau> tableaux = new List<LigneTableau>();
            for(int i=1;i<=10;i++)
            {
                LigneTableau ligne = new LigneTableau() 
                { nombre = id, indice = i, resultat = id * i };
                tableaux.Add(ligne);
            }
            return View(tableaux);
        }
    }
}