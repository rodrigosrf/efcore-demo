using EFCore.Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

public class AppMain : DbContext
{

    public DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=testedb;User Id=admin;Password=123456;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pessoa>()
            .ToTable("pessoa");

        modelBuilder.Entity<Pessoa>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Pessoa>()
            .Property(p => p.Id)
            .HasColumnName("Id")
            .IsRequired();

        modelBuilder.Entity<Pessoa>()
            .Property(p => p.Nome)
            .HasColumnName("nome")
            .HasMaxLength(150)
            .IsRequired();

        modelBuilder.Entity<Pessoa>()
            .Property(p => p.CPF)
            .HasColumnName("cpf")
            .HasMaxLength(11)
            .IsRequired();

    }


}

public class Produto
{

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public decimal Valor { get; private set; }
    public Produto(int id, string nome, string descricao, decimal valor)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
    }

}


