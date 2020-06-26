using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class CompetidoresServicio : ICompetidoresServicio
    {
        protected ICompetidoresRepositorio CompetidoresRepositorio { get; set; }

        public CompetidoresServicio(Web3EA2Entities ctx)
        {
            CompetidoresRepositorio = new CompetidoresRepositorio(ctx);
        }

        public void AltaCompetidor(Competidor competidor)
        {
            CompetidoresRepositorio.AltaCompetidor(competidor);
        }

        public List<Competidor> ListaCompetidores()
        {
            return CompetidoresRepositorio.ListaCompetidores();
        }
    }
}
