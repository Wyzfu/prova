﻿// <auto-generated />
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PROJwebapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220920123328_AddSalarioEmailTableFuncionarios")]
    partial class AddSalarioEmailTableFuncionarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<int>("CriadoEm")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<double>("Salario")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
