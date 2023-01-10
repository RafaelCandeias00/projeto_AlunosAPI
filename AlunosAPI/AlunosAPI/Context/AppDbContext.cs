using AlunosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    AlunoId = 1,
                    Nome = "Maria da Penha",
                    Email = "mariapenha@email.com",
                    Idade = 23
                },
                new Aluno
                {
                    AlunoId = 2,
                    Nome = "Manuel Bueno",
                    Email = "manuelbueno@email.com",
                    Idade = 22
                }
                );
        }
    }
}
