using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class PacotesController : ControllerBase
    {
        private IPacotesRepository _pacotesRepository;
        public PacotesController()
        {
            _pacotesRepository = new PacotesRepository();
        }
        /// <summary>
        /// tras todos os pacotes em uma lista
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_pacotesRepository.Listar());
        }
        /// <summary>
        /// listar o pacote pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult BuscarporId(int id)
        {
            return Ok(_pacotesRepository.BuscarPorId(id));
        }
        /// <summary>
        /// cadastra um novo pacote
        /// </summary>
        /// <param name="novoPacote"></param>
        /// <returns></returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Pacotes novoPacote)
        {
            try
            {
                _pacotesRepository.Cadastrar(novoPacote);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// altera dados do pacote
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pacoteAlterado"></param>
        /// <returns></returns>
        [Authorize(Roles = "1")]

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Pacotes pacoteAlterado)
        {
            Pacotes pacoteBuscado = _pacotesRepository.BuscarPorId(id);
            if (pacoteBuscado == null)
            {
                return NotFound
                    (
                        new
                        {
                            mensagem = "pacote não encontrado",
                            erro = true
                        }
                    );
            }
            return Ok("alterado");
        }
        /// <summary>
        /// deletar o pacote especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _pacotesRepository.Deletar(id);

            return Ok("pacote deletado");
        }
    }
}