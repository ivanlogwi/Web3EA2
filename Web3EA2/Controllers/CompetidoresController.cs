using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web3EA2.Controllers
{
    public class CompetidoresController : Controller
    {
        ICompetidoresServicio CompetidoresServicio;

        public CompetidoresController()
        {
            Web3EA2Entities ctx = new Web3EA2Entities();
            CompetidoresServicio = new CompetidoresServicio(ctx);
        }

        // GET: Competidores
        public ActionResult ListaCompetidores()
        {
            List<Competidor> competidores = CompetidoresServicio.ListaCompetidores();
            return View(competidores);
        }

        [HttpGet]
        public ActionResult AltaCompetidor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AltaCompetidor(Competidor competidor)
        {
            if (ModelState.IsValid)
            {
                CompetidoresServicio.AltaCompetidor(competidor);
                return RedirectToAction("ListaCompetidores");
            }
            else
            {
                return View(competidor);
            }
        }
    }
}