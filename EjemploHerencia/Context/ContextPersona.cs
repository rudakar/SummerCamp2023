using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Context
{

    public class ContextoPersona : DbContext
    {
        public ContextoPersona(DbContextOptions<ContextoPersona> options) : base(options)
        {

        }
        public DbSet<Persona> personas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

}