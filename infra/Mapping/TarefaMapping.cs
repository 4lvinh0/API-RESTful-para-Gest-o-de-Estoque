using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTful_para_Gestao_de_Estoque.core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_RESTful_para_Gestao_de_Estoque.infra.Mapping
{
    public class TarefaMapping : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> b)
        {
            b.ToTable("Tarefas");

            b.HasKey( x => x.Id);

            b.Property( x => x.Title)
                .IsRequired(true)
                .HasMaxLength(128);
            
            b.Property( x => x.Description)
                .HasMaxLength(1028);

            b.Property( x => x.Status);

            b.HasOne( x => x.Usuario)
            .WithMany( x => x.Tarefa)
            .HasForeignKey( x => x.UsuarioId)
            .HasPrincipalKey ( x => x.Id);
        }
    }
}