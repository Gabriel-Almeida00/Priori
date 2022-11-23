using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_DADOS.Interfaces
{
    public interface IGraficoRepositorio
    {
        object PegarTotalInvestidoPeloUsuarioId(string clienteId, int ano);

        object PegarRetornoDoInvestimentoPeloUsuarioId(string clienteId, int ano);
    }
}
