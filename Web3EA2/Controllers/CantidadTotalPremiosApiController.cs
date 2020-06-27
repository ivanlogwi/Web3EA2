using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web3EA2.Controllers
{
    [Serializable]
    public class CantidadTotalPremiosApiController : ApiController
    {
        IPremiosServicio PremiosServicio;

        public CantidadTotalPremiosApiController()
        {
            Web3EA2Entities ctx = new Web3EA2Entities();
            PremiosServicio = new PremiosServicio(ctx);
        }

        // GET api/<controller>
        [HttpGet]
        public string Get(int id)
        {
            return PremiosServicio.TotalPremiosPorAño(id);
        }

        
    }
}