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
            var duplicado = Contexto.CantidadPremiosPorCompetidor.Any(o => o.Año == cantidadPremiosPorCompetidor.Año && o.idCompetidor == cantidadPremiosPorCompetidor.idCompetidor);
            
            if (duplicado)
            {
                CantidadPremiosPorCompetidor premiosNuevos = Contexto.CantidadPremiosPorCompetidor
                                                            .Where(o => o.Año == cantidadPremiosPorCompetidor.Año && o.idCompetidor == cantidadPremiosPorCompetidor.idCompetidor)
                                                            .FirstOrDefault();
                
                //CantidadPremiosPorCompetidor premiosNuevos = (from p 
                //                                              in Contexto.CantidadPremiosPorCompetidor
                //                                              where p.Año == cantidadPremiosPorCompetidor.Año 
                //                                              && p.idCompetidor == cantidadPremiosPorCompetidor.idCompetidor
                //                                              select p).FirstOrDefault();

                premiosNuevos.CantidadPremios = cantidadPremiosPorCompetidor.CantidadPremios;
            }
            else
            {
                Contexto.CantidadPremiosPorCompetidor.Add(cantidadPremiosPorCompetidor);
            }
            Contexto.SaveChanges();
        }

        public List<CantidadPremiosPorCompetidor> ListaPremios()
        {
            return Contexto.CantidadPremiosPorCompetidor.ToList();
        }

        public string TotalPremiosPorAño(int Año)
        {
            var totalPremios = Contexto.CantidadPremiosPorCompetidor
                       .Where(o => o.Año == Año)
                       .Select(o => (int?) o.CantidadPremios)
                       .Sum() ?? 0;
            
                return totalPremios.ToString();
        }
    }


}
