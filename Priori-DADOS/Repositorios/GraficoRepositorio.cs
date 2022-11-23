using Priori_DADOS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Priori_DADOS.Repositorios
{
    public class GraficoRepositorio : IGraficoRepositorio
    {
        private readonly Contexto _contexto;
        public GraficoRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }
       
        public object PegarRetornoDoInvestimentoPeloUsuarioId(string clienteId, int ano)
        {
            try
            {
                return _contexto.CarteiraInvestimentos
                    .Where(d => d.id_cliente == clienteId && d.tempo_aplicacao == ano)
                    .OrderBy(d => d.tempo_aplicacao)
                    .GroupBy(d => d.tempo_aplicacao)
                    .Select(d => new
                    {
                        tempo_aplicacao = d.Key,
                        Valores = d.Sum(x => x.valor_aplicado)
                    });
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public object PegarTotalInvestidoPeloUsuarioId(string clienteId, int ano)
        {
            throw new NotImplementedException();
        }
    }
}
