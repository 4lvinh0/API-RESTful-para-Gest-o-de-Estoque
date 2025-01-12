using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using API_RESTful_para_Gestao_de_Estoque.core.entities;
using API_RESTful_para_Gestao_de_Estoque.infra.Mapping;
using Microsoft.EntityFrameworkCore;

namespace API_RESTful_para_Gestao_de_Estoque.infra
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Name = "Eduardo", Senha = 123456 }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseInMemoryDatabase("InMemoryDb");


        public DbSet<Tarefa> Tarefas { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;
    }
}