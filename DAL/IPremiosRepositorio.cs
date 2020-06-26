using System.Collections.Generic;

namespace DAL
{
    public interface IPremiosRepositorio
    {
        Web3EA2Entities Contexto { get; set; }

        void AltaPremios(CantidadPremiosPorCompetidor cantidadPremiosPorCompetidor);

        List<CantidadPremiosPorCompetidor> ListaPremios();

    }
}