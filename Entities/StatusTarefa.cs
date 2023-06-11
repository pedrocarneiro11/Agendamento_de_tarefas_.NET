using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace agendamento_de_tarefas.Entities
{
    public enum StatusTarefa
    {
        [Description("Pendente")] // 0
        Pendente,
        [Description("EmAndamento")] // 1
        EmAndamento,
        [Description("Concluida")] // 2
        Concluida
    }
}