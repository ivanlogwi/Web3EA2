using System.Collections.Generic;

namespace DAL
{
    public interface ICompetidoresRepositorio
    {
        Web3EA2Entities Contexto { get; set; }

        void AltaCompetidor(Competidor competidor);

        List<Competidor> ListaCompetidores();

    }
}