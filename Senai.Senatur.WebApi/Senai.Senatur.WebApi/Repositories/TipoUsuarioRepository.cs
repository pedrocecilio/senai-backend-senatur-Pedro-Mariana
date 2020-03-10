using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    /// <summary>
    /// Repositório responsável pelo repositório dos tipos de usuário
    /// </summary>
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        SenaturContext ctx = new SenaturContext();

        public TipoUsuario BuscarPorId(int id)
        {
            // Retorna o primeiro tipo de usuário para o ID informado
            return ctx.TiposUsuario.FirstOrDefault(tu => tu.IdTipoUsuario == id);
        }

        /// <summary>
        /// Lista todos os tipos de usuário
        /// </summary>
        /// <returns>Uma lista de tipos de usuário</returns>
        public List<TipoUsuario> Listar()
        {
            // Retorna uma lista com todas as informações dos tipos de usuário
            return ctx.TiposUsuario.ToList();
        }
    }
}
