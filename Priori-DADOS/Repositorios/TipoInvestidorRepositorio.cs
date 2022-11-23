using Microsoft.AspNetCore.Identity;
using Priori_DADOS.Interfaces;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priori_OBJ;

namespace Priori_DADOS.Repositorios
{
    public class TipoInvestidorRepositorio : RepositorioGenerico<tbltipoInvestidor>, ITipoInvestidorRepositorio
    {

        private readonly Contexto _contexto;
        private readonly UserManager<tbltipoInvestidor> _gerenciadorUsuarios;
        private readonly RoleManager<tbltipoInvestidor> _gerenciadorFuncoes;

        public TipoInvestidorRepositorio(Contexto contexto, RoleManager<Funcao> gerenciadorFuncoes) : base(contexto)
        {
            _contexto = contexto;
          
        }

        public async Task AdicionarTipo(tbltipoInvestidor tipo)
        {
            try
            {
                await _gerenciadorFuncoes.CreateAsync(tipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task AtualizarTipo(tbltipoInvestidor tipo)
        {
            try
            {
                object value = await _gerenciadorUsuarios.UpdateAsync(tipo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable<tbltipoInvestidor> FiltrarFuncoes(string nome_categoria)
        {
            throw new NotImplementedException();
        }
    }
}
