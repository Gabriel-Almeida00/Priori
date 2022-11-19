using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priori_DADOS.Interfaces
{
    public interface IInvestimentoRepositorio : IRepositorioGenerico<tblInvestimentos>
    {
        new IQueryable<tblInvestimentos> PegarTodos();

        new Task<tblInvestimentos> PegarPeloId(int id);

        IQueryable<tblInvestimentos> FiltrarInvestimentos(string nomeInvestimento);

        IQueryable<tblInvestimentos> PegarInvestimentoPeloTipo(string tipo_Investimento);
    }
}
