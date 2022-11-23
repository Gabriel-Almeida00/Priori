using Microsoft.EntityFrameworkCore;
using Priori_DADOS.Interfaces;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priori_DADOS.Repositorios
{
    public class InvestimentoRepositorio : RepositorioGenerico<tblInvestimentos>, IInvestimentoRepositorio
    {
        private readonly Contexto _contexto;
        public InvestimentoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public IQueryable<tblInvestimentos> FiltrarInvestimentos(string nomeInvestimento)
        {
            throw new NotImplementedException();
        }

        public IQueryable<tblInvestimentos> PegarInvestimentoPeloTipo(string tipo_Investimento)
        {
            try
            {
                return _contexto.investimentos.Include(c => c.tipo_investimento).Where(c => c.tipo_investimento == tipo_Investimento);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
