using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo TipoUsuarioRepository
    /// </summary>
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Lista todos os tipos de usuários
        /// </summary>
        /// <returns>Uma lista de tipos de usuários</returns>
        List<TipoUsuario> Listar();

        /// <summary>
        /// Busca um tipo de usuário através do ID
        /// </summary>
        /// <param name="id">ID do tipo de usuário buscado</param>
        /// <returns>Um tipo de usuário buscado</returns>
        TipoUsuario BuscarPorId(int id);

       
    }
}
