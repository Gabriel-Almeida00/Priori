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
    public class ClienteRepositorio : RepositorioGenerico<tblClientes>, IClienteRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<tblClientes> _gerenciadorUsuarios;
        private readonly SignInManager<tblClientes> _gerenciadorLogin;
        public ClienteRepositorio(Contexto contexto, UserManager<tblClientes> gerenciadorUsuarios, SignInManager<tblClientes> gerenciadorLogin) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorUsuarios = gerenciadorUsuarios;
            _gerenciadorLogin = gerenciadorLogin;
        }

        public async Task AtualizarCliente(tblClientes cliente)
        {
            try
            {
                await _gerenciadorUsuarios.UpdateAsync(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IdentityResult> CriarCliente(tblClientes cliente, string senha)
        {
            try
            {
                return await _gerenciadorUsuarios.CreateAsync(cliente, senha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task IncluirClienteEmFuncao(tblClientes cliente, string funcao)
        {
            try
            {
                await _gerenciadorUsuarios.AddToRoleAsync(cliente, funcao);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task LogarCliente(tblClientes cliente, bool lembrar)
        {
            try
            {
                await _gerenciadorLogin.SignInAsync(cliente, false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<tblClientes> PegarClientePeloEmail(string email)
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

        public async Task<IList<string>> PegarFuncoesCliente(tblClientes cliente)
        {
            try
            {
                return await _gerenciadorUsuarios.GetRolesAsync(cliente);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> PegarQuantidadeClienteRegistrados()
        {
            try
            {
                return await _contexto.cliente.CountAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
