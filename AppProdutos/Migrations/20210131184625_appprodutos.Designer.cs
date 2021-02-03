﻿// <auto-generated />
using AppProdutos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppProdutos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210131184625_appprodutos")]
    partial class appprodutos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppProdutos.Models.Produto", b =>
                {
                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImagemProdutoUrl")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("ValorProduto")
                        .HasColumnType("decimal");

                    b.HasKey("NomeProduto");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
