using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using _pasta_projeto.Entities;

namespace _pasta_projeto.Models
{
    public class Tarefa
    {
        public int Id{ get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public StatusTarefa StatusTarefa { get; set; }
    }
}