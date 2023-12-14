using DotnetAT.Models.Dominio;
using Microsoft.EntityFrameworkCore;

namespace DotnetAT.Dados
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
