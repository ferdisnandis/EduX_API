﻿// <auto-generated />
using System;
using EduX_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EduX_API.Migrations
{
    [DbContext(typeof(EduXContext))]
    partial class EduXContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EduX_API.Domains.AlunoTurma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTurma")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdTurma");

                    b.HasIndex("IdUsuario");

                    b.ToTable("AlunoTurma");
                });

            modelBuilder.Entity("EduX_API.Domains.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("EduX_API.Domains.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdInstituicao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdInstituicao");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("EduX_API.Domains.Curtida", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DicaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdDica")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DicaId");

                    b.HasIndex("IdDica");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Curtida");
                });

            modelBuilder.Entity("EduX_API.Domains.Dica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Imagem")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Texto")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Dica");
                });

            modelBuilder.Entity("EduX_API.Domains.Instituicao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instituicao");
                });

            modelBuilder.Entity("EduX_API.Domains.Objetivo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdCategoria")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UrlImagem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Objetivo");
                });

            modelBuilder.Entity("EduX_API.Domains.ObjetivoAluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataAlcancado")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdAlunoTurma")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdObjetivo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTurma")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Nota")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("IdAlunoTurma");

                    b.HasIndex("IdObjetivo");

                    b.HasIndex("IdTurma");

                    b.ToTable("ObjetivoAluno");
                });

            modelBuilder.Entity("EduX_API.Domains.Perfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Permissao")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("EduX_API.Domains.ProfessorTurma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdTurma")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdTurma");

                    b.HasIndex("IdUsuario");

                    b.ToTable("ProfessorTurma");
                });

            modelBuilder.Entity("EduX_API.Domains.Turma", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdCurso")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("IdCurso");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("EduX_API.Domains.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimoAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdPerfil")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EduX_API.Domains.AlunoTurma", b =>
                {
                    b.HasOne("EduX_API.Domains.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("IdTurma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduX_API.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_API.Domains.Curso", b =>
                {
                    b.HasOne("EduX_API.Domains.Instituicao", "Instituicao")
                        .WithMany()
                        .HasForeignKey("IdInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_API.Domains.Curtida", b =>
                {
                    b.HasOne("EduX_API.Domains.Dica", null)
                        .WithMany("Curtidas")
                        .HasForeignKey("DicaId");

                    b.HasOne("EduX_API.Domains.Dica", "Dica")
                        .WithMany()
                        .HasForeignKey("IdDica")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EduX_API.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_API.Domains.Dica", b =>
                {
                    b.HasOne("EduX_API.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_API.Domains.Objetivo", b =>
                {
                    b.HasOne("EduX_API.Domains.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_API.Domains.ObjetivoAluno", b =>
                {
                    b.HasOne("EduX_API.Domains.AlunoTurma", "AlunoTurma")
                        .WithMany()
                        .HasForeignKey("IdAlunoTurma")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EduX_API.Domains.Objetivo", "Objetivo")
                        .WithMany()
                        .HasForeignKey("IdObjetivo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduX_API.Domains.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("IdTurma")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_API.Domains.ProfessorTurma", b =>
                {
                    b.HasOne("EduX_API.Domains.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("IdTurma")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduX_API.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_API.Domains.Turma", b =>
                {
                    b.HasOne("EduX_API.Domains.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduX_API.Domains.Usuario", b =>
                {
                    b.HasOne("EduX_API.Domains.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
