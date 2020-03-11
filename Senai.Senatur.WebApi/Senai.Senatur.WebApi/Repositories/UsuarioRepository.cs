using Microsoft.EntityFrameworkCore;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Domains.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Domains.Repositories
{
    /// <summary>
    /// Repositório responsável pelo repositório dos usuários
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        SenaturContext ctx = new SenaturContext();

        public Usuarios BuscarPorEmailSenha(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(e=>e.Email ==email && e.Senha == senha);
        }

        /// <summary>
        /// Busca um usuário através do ID
        /// </summary>
        /// <param name="id">ID do usuário que será buscado</param>
        /// <returns>Um usuário buscado</returns>
        public Usuarios BuscarPorId(int id)
        {
            // Retorna o primeiro usuário para o ID informado
            return ctx.Usuarios.Include(u => u.IdTipoUsuarioNavigation).FirstOrDefault(u => u.IdUsuario == id);
        }

        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        public List<Usuarios> Listar()
        {
            // Retorna uma lista com todas as informações dos usuários
            return ctx.Usuarios.Include(t=>t.IdTipoUsuarioNavigation).ToList();
        }
    }
}
