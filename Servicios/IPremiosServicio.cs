using DAL;
using System.Collections.Generic;

namespace Servicios
{
    public interface IPremiosServicio
    {
        void AltaPremios(CantidadPremiosPorCompetidor cantidadPremiosPorCompetidor);

        List<CantidadPremiosPorCompetidor> ListaPremios();
    }
}