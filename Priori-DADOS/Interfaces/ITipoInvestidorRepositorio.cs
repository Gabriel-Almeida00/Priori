using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priori_DADOS.Interfaces
{
    public interface ITipoInvestidorRepositorio : IRepositorioGenerico<tbltipoInvestidor>
    {
        Task AdicionarTipo(tbltipoInvestidor tipo);

        Task AtualizarTipo(tbltipoInvestidor tipo);

        IQueryable<tbltipoInvestidor> FiltrarFuncoes(string nome_categoria);
    }
}
