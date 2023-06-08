using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _pasta_projeto.Context;
using _pasta_projeto.Models;
using _pasta_projeto.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace pasta_projeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : Controller
    {
        private readonly TarefaContext _context;

        public TarefaController(TarefaContext context)
        {
            _context = context;
        }

        // TODO: CRIAR METODO POST : /Tarefa  

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Add(tarefa);            
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetByID), new { id = tarefa.Id}, tarefa);
        }

        // TODO: Criar método GetByID

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var tarefa = _context.Tarefas.Find(id);

            if(tarefa != null)
            {
                int Id = id;
                string Titulo = tarefa.Titulo;
                string Descricao = tarefa.Descricao;
                DateTime Data = tarefa.Data;
                StatusTarefa statusTarefa = tarefa.StatusTarefa;

                return Ok(tarefa);
            }
            else 
            {
                return NotFound();
            }
        }

        // TODO: CRIAR METODO GET : /Tarefa/{id}
        // TODO: CRIAR METODO GET : /Tarefa/ObterTodos
        // TODO: CRIAR METODO GET : /Tarefa/ObterPorTitulo
        // TODO: CRIAR METODO GET : /Tarefa/ObterPorData
        // TODO: CRIAR METODO GET : /Tarefa/ObterPorStatus
        // TODO: CRIAR METODO PUT: /Tarefa/{id}
        // TODO: CRIAR METODO DELETE: /Tarefa/{id}
    }
}