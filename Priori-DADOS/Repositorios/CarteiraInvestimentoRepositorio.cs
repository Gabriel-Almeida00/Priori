using Microsoft.EntityFrameworkCore;
using Priori_DADOS.Interfaces;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priori_DADOS.Repositorios
{
    public class CarteiraInvestimentoRepositorio : RepositorioGenerico<tblCarteiraInvestimentos>, ICarteiraInvestimentosRepositorio
    {
        private readonly Contexto _contexto;
        public CarteiraInvestimentoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public IQueryable<tblInvestimentos> FiltrarGanhos(string nomeInvestimento)
        {
            throw new NotImplementedException();
        }

        public IQueryable<tblInvestimentos> PegarInvestimentoPeloUsuarioId(string clienteId)
        {
            try
            {
                return (IQueryable<tblInvestimentos>)_contexto.CarteiraInvestimentos.Include(g => g.saldo).Include(g => g.Investimentos).Where(g => g.id_cliente == clienteId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<double> PegarInvestimentoTotaldoClienteId(string clienteId)
        {
            try
            {
                return (double)await _contexto.CarteiraInvestimentos.Where(g => g.id_cliente == clienteId).SumAsync(g => g.valor_aplicado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
