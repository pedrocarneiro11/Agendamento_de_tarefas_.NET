using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace agendamento_de_tarefas.Entities
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public StatusTarefa StatusTarefa { get; set; }
    }
}