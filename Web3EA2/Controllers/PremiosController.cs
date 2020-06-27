using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web3EA2.Controllers
{
    public class PremiosController : Controller
    {
        IPremiosServicio PremiosServicio;
        ICompetidoresServicio CompetidoresServicio;

        public PremiosController()
        {
            Web3EA2Entities ctx = new Web3EA2Entities();
            PremiosServicio = new PremiosServicio(ctx);
            CompetidoresServicio = new CompetidoresServicio(ctx);
        }

        public ActionResult ListaPremios()
        {
            List<CantidadPremiosPorCompetidor> premios = PremiosServicio.ListaPremios();
            return View(premios);
        }

        [HttpGet]
        public ActionResult AltaPremios()
        {
            ViewBag.NombreCompetidor = CompetidoresServicio.ListaCompetidores();
            return View();
        }

        [HttpPost]
        public ActionResult AltaPremios(CantidadPremiosPorCompetidor premios)
        {

            if (ModelState.IsValid)
            {
                PremiosServicio.AltaPremios(premios);
                return RedirectToAction("ListaPremios");
            }
            else
            {
                ViewBag.IdNombreCompetidorSeleccionado = premios.idCompetidor;
                ViewBag.NombreCompetidor = CompetidoresServicio.ListaCompetidores();
                return View(premios);
            }
        }
    }
}