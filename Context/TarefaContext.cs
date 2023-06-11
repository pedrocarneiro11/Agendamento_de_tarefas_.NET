using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using agendamento_de_tarefas.Entities;
using Microsoft.EntityFrameworkCore;

namespace agendamento_de_tarefas.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>()
                .Property(t => t.StatusTarefa)
                .HasConversion<string>(); // Converte o enum para string

            base.OnModelCreating(modelBuilder);
        }
    }
}