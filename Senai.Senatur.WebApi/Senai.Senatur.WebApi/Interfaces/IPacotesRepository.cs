using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacotesRepository
    {
        List<Pacotes> Listar();

        void Cadastrar(Pacotes novoPacote);

        void Deletar(int id);

        void Alterar(int id, Pacotes pacoteAlterado);

        Pacotes BuscarPorId(int id);
    }
}
