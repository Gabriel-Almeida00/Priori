using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Priori_DADOS.Interfaces;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Priori_DADOS.Repositorios
{
    public class AgenteRepositorio : RepositorioGenerico<tblAgentes>, IAgentesRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<tblAgentes> _gerenciadorUsuarios;
        private readonly SignInManager<tblAgentes> _gerenciadorLogin;

        public AgenteRepositorio(Contexto contexto, UserManager<tblAgentes> gerenciadorUsuarios, SignInManager<tblAgentes> gerenciadorLogin) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorUsuarios = gerenciadorUsuarios;
            _gerenciadorLogin = gerenciadorLogin;
        }

        public async Task AtualizarAgente(tblAgentes agente)
        {
            try
            {
                await _gerenciadorUsuarios.UpdateAsync(agente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task AtualizarCliente(tblAgentes clieagentente)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> CriarAgente(tblAgentes agente, string senha)
        {

            try
            {
                return await _gerenciadorUsuarios.CreateAsync(agente, senha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task IncluirAgenteEmFuncao(tblAgentes agente, string funcao)
        {
            try
            {
                await _gerenciadorUsuarios.AddToRoleAsync(agente, funcao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task LogarCliente(tblAgentes agente, bool lembrar)
        {
            try
            {
                await _gerenciadorLogin.SignInAsync(agente, false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<tblAgentes> PegarClientePeloEmail(string email)
        {
            try
            {
                return await _gerenciadorUsuarios.FindByEmailAsync(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IList<string>> PegarFuncoesAgente(tblAgentes agente)
        {
            try
            {
                return await _gerenciadorUsuarios.GetRolesAsync(agente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task<IList<string>> PegarFuncoesCliente(tblAgentes agente)
        {
            throw new NotImplementedException();
        }

        public async Task<int> PegarQuantidadeAgenteRegistrados()
        {
            try
            {
                return await _contexto.Agente.CountAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task VincularClienteParaAgente(tblAgentes agente, string clienteId)
        {
            try
            {
                await _gerenciadorUsuarios.AddToRoleAsync(agente, clienteId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
