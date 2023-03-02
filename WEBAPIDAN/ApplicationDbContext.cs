using Microsoft.EntityFrameworkCore;
using WEBAPIDAN.Entidades;


namespace WEBAPIDAN
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Teclado> Teclados { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
       // public DbSet<Marca> Marcas { get; set; } 


    }
}
