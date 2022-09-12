using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

namespace WebApplication8.Data
{
    public class WebApplication8DbContext : DbContext
    {
        public DbSet<Supermercado> Supermercados { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; }

        public WebApplication8DbContext(DbContextOptions<WebApplication8DbContext> options) : base(options)
        {

        }
    }
}
