using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Domains.Interfaces
{
    /// <summary>
    /// Interface responsável pelo UsuarioRepository
    /// </summary>
    interface IUsuarioRepository
    {

        Usuarios BuscarPorEmailSenha(string email, string senha);

        List<Usuarios> Listar();

        Usuarios BuscarPorId(int id);

    }
}
