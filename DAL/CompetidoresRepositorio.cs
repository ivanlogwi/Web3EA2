using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CompetidoresRepositorio : ICompetidoresRepositorio
    {
        public Web3EA2Entities Contexto { get; set; }

        public CompetidoresRepositorio(Web3EA2Entities ctx)
        {
            Contexto = ctx;
        }

        public void AltaCompetidor(Competidor competidor)
        {
            Contexto.Competidor.Add(competidor);
            Contexto.SaveChanges();
        }

        public List<Competidor> ListaCompetidores()
        {
            return Contexto.Competidor.ToList();
        }
    }


}
