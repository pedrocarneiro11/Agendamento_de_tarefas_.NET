using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _pasta_projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace _pasta_projeto.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefa>()
            .Property(t => t.StatusTarefa)
            .HasConversion<string>(); // Converte o enum para string

        base.OnModelCreating(modelBuilder);
    }
    }
}