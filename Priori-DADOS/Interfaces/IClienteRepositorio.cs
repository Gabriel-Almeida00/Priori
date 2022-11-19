using Microsoft.AspNetCore.Identity;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Priori_DADOS.Interfaces
{
    internal interface IClienteRepositorio : IRepositorioGenerico<tblClientes>
    {
        Task<int> PegarQuantidadeUsuariosRegistrados();

        Task<IdentityResult> CriarCliente(tblClientes cliente, string senha);

        Task IncluirClienteEmFuncao(tblClientes cliente, string funcao);

        Task LogarCliente(tblClientes cliente, bool lembrar);

        Task<tblClientes> PegarClientePeloEmail(string email);

        Task<IList<string>> PegarFuncoesCliente(tblClientes cliente);

        Task AtualizarCliente(tblClientes cliente);
    }
}
