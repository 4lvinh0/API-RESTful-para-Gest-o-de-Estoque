﻿// <auto-generated />
using System;
using API_RESTful_para_Gestao_de_Estoque.infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_RESTful_para_Gestao_de_Estoque.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250107213351_firstMigrations")]
    partial class firstMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_RESTful_para_Gestao_de_Estoque.core.entities.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("DataVencimento")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasMaxLength(1028)
                        .HasColumnType("nvarchar(1028)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Tarefas", (string)null);
                });

            modelBuilder.Entity("API_RESTful_para_Gestao_de_Estoque.core.entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Senha")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Eduardo",
                            Senha = 123456
                        });
                });

            modelBuilder.Entity("API_RESTful_para_Gestao_de_Estoque.core.entities.Tarefa", b =>
                {
                    b.HasOne("API_RESTful_para_Gestao_de_Estoque.core.entities.Usuario", "Usuario")
                        .WithMany("Tarefa")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("API_RESTful_para_Gestao_de_Estoque.core.entities.Usuario", b =>
                {
                    b.Navigation("Tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
