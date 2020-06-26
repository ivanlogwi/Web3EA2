using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PremiosRepositorio : IPremiosRepositorio
    {
        public Web3EA2Entities Contexto { get; set; }

        public PremiosRepositorio(Web3EA2Entities ctx)
        {
            Contexto = ctx;
        }

        public void AltaPremios(CantidadPremiosPorCompetidor cantidadPremiosPorCompetidor)
        {
            Contexto.CantidadPremiosPorCompetidor.Add(cantidadPremiosPorCompetidor);
            Contexto.SaveChanges();
        }

        public List<CantidadPremiosPorCompetidor> ListaPremios()
        {
            return Contexto.CantidadPremiosPorCompetidor.ToList();
        }
    }

    
}
