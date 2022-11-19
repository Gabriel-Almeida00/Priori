using Microsoft.AspNetCore.Identity;
using Priori_OBJ.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Priori_DADOS.Interfaces
{
    public interface IAgentesRepositorio : IRepositorioGenerico<tblAgentes>
    {
        Task<int> PegarQuantidadeAgenteRegistrados();

        Task<IdentityResult> CriarAgente(tblAgentes agente, string senha);

        Task IncluirAgenteEmFuncao(tblAgentes agente, string funcao);

        Task VincularClienteParaAgente(tblAgentes agente, string clienteId);

        Task LogarCliente(tblAgentes agente, bool lembrar);

        Task<tblAgentes> PegarClientePeloEmail(string email);

        Task<IList<string>> PegarFuncoesCliente(tblAgentes agente);

        Task AtualizarCliente(tblAgentes clieagentente);
    }
}
