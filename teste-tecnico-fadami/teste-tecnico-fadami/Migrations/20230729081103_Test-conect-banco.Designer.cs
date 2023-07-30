﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using teste_tecnico_fadami.Data;

#nullable disable

namespace teste_tecnico_fadami.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230729081103_Test-conect-banco")]
    partial class Testconectbanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("teste_tecnico_fadami.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BL_ATIVO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LOGIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QTD_ERRO_LOGIN")
                        .HasColumnType("int");

                    b.Property<string>("SENHA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ULTIMO_ACESSO")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}