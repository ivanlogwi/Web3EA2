using DAL;
using System.Collections.Generic;

namespace Servicios
{
    public interface ICompetidoresServicio
    {
        void AltaCompetidor(Competidor competidor);

        List<Competidor> ListaCompetidores();
    }
}