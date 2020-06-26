using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class PremiosServicio : IPremiosServicio
    {
        protected IPremiosRepositorio PremiosRepositorio { get; set; }

        public PremiosServicio(Web3EA2Entities ctx)
        {
            PremiosRepositorio = new PremiosRepositorio(ctx);
        }

        public void AltaPremios(CantidadPremiosPorCompetidor cantidadPremiosPorCompetidor)
        {
            PremiosRepositorio.AltaPremios(cantidadPremiosPorCompetidor);
        }

        public List<CantidadPremiosPorCompetidor> ListaPremios()
        {
            return PremiosRepositorio.ListaPremios();
        }
    }
}
