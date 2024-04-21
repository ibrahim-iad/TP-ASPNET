using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP1ASP.Models;

namespace TP1ASP.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Afficher(int nombre)
        {
            if (ModelState.IsValid)
            {
                List<LigneTableau> tableaux = new List<LigneTableau>();
                for (int i = 1; i <= 10; i++)
                {
                    LigneTableau ligne = new LigneTableau() { nombre = nombre, indice = i, resultat = nombre * i };
                    tableaux.Add(ligne);
                }
                return View(tableaux);
            }
            return View("Index", nombre);
        }
    }
}