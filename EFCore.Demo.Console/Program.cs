using Microsoft.EntityFrameworkCore;



Console.WriteLine("Hello, World!");

public class AppMain : DbContext
{

    public DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=admin;Password=123456;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }


}


public class Pessoa
{
    public Pessoa(int id, string nome, string cpf)
    {
        Id = id;
        Nome = nome;
        CPF = cpf;
    }

    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string CPF { get; private set; }


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


