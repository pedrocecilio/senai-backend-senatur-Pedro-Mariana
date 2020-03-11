using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{

    public class PacotesRepository :IPacotesRepository
    {
        SenaturContext ctx = new SenaturContext();
        public void Alterar(int id, Pacotes pacoteAlterado)
        {
            Pacotes pacote = ctx.Pacotes.FirstOrDefault(e => e.IdPacote == id);
            if (String.IsNullOrEmpty(pacoteAlterado.NomePacote) == false)
            {
                pacote.NomePacote = pacoteAlterado.NomePacote;
            }
            

            if( string.IsNullOrEmpty(pacoteAlterado.Descricao)== false)
            {
                pacote.Descricao = pacoteAlterado.Descricao;
            }
           

            if(pacoteAlterado.DataIda != null)
            {
                pacote.DataIda = pacoteAlterado.DataIda;
            }
            if (pacoteAlterado.DataVolta != null)
            {
                pacote.DataVolta = pacoteAlterado.DataVolta;
            }
            if(pacoteAlterado.Valor != null)
            {
                pacote.Valor = pacoteAlterado.Valor;
            }

            if(pacote.Cidade != null)
            {
                pacote.Cidade = pacoteAlterado.Cidade;
            }
            ctx.SaveChanges();
        }

        public Pacotes BuscarPorId(int id)
        {
            return ctx.Pacotes.FirstOrDefault(e => e.IdPacote == id);
        }

        public void Cadastrar(Pacotes novoPacote)
        {
            ctx.Pacotes.Add(novoPacote);
            ctx.SaveChanges();
        }
        public void Deletar(int id)
        {
            ctx.Pacotes.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }
        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }



    }
}
