using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using WebApi_.NET_9.Models;

namespace WebApi_.NET_9.Data
{   //conexão com banco de dados
    public class AppDbContext : DbContext
    {
        //construtor - atalho ctor para criar construtor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ProdutoModel>Produtos{get;set;}

    }
}
