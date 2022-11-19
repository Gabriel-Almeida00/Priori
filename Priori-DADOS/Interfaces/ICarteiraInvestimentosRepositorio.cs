using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priori_DADOS.Interfaces
{
    public interface ICarteiraInvestimentosRepositorio : IRepositorioGenerico<tblCarteiraInvestimentos>
    {
        IQueryable<tblInvestimentos> PegarInvestimentoPeloUsuarioId(string clienteId);

        IQueryable<tblInvestimentos> FiltrarGanhos(string nomeInvestimento);

        Task<double> PegarInvestimentoTotaldoClienteId(string clienteId);
    }
}
