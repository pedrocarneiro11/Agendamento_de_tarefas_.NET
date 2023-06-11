using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ComponentModel;
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

        // CRIAR METODO POST : /Tarefa  OK

        [HttpPost]
        public IActionResult Create(Tarefa tarefa)
        {
            _context.Add(tarefa);            
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetByID), new { id = tarefa.Id}, tarefa);
        }

        // Criar método GetByID : /Tarefa/{id} OK

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
        // CRIAR METODO GET : /Tarefa/ObterTodos OK
        [HttpGet]
        public IActionResult GetAll()
        {
            var tarefas = _context.Tarefas.ToList();

            if (tarefas != null)
            {
                foreach (var tarefa in tarefas)
                {
                    return Ok(tarefas);
                }
            }

            return null;
        }
        // CRIAR METODO GET : /Tarefa/ObterPorTitulo OK
        [HttpGet("ObterPorTitulo")]
        public IActionResult GetByTitle(string Titulo)
        {
            var titulos = _context.Tarefas.Where(x => x.Titulo.Contains(Titulo));
            var count = titulos.Count();

            if (count > 0)
            {
                string titulo = Titulo;
                return Ok(titulos);
            }
            else
            {
                return NotFound();
            }
        }

        // CRIAR METODO GET : /Tarefa/ObterPorData OK
        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            var count = tarefa.Count();

            if(tarefa != null && count > 0)
            {
                return Ok(tarefa);
            }
            else 
            {
                return NotFound();
            }
        }

        // CRIAR METODO PUT: /Tarefa/{id} OK
        [HttpPut("{id}")]
        public IActionResult Update(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
            {
                return NotFound();
            } 
            else 
            {
                tarefaBanco.Titulo = tarefa.Titulo;
                tarefaBanco.Descricao = tarefa.Descricao;
                tarefaBanco.Data = tarefa.Data;
                tarefaBanco.StatusTarefa = tarefa.StatusTarefa;

                _context.Tarefas.Update(tarefaBanco);
                _context.SaveChanges();

                return Ok(tarefaBanco);
            }
        }


        
        // CRIAR METODO GET : /Tarefa/ObterPorStatus  

        [HttpGet("ObterPorStatus")]
        public IActionResult GetByStatus(StatusTarefa StatusTarefa)
        {
            var status = _context.Tarefas.Where(x => x.StatusTarefa == StatusTarefa);

            var count = status.Count();

            if (count > 0)
            {
                return Ok(status);
            }
            else
            {
                return NotFound();
            }
        }

        
        // TODO: CRIAR METODO DELETE: /Tarefa/{id}
    }
}