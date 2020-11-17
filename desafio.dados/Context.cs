using System.Data.Entity;

namespace desafio.dados
{
    public class Context : DbContext
    {
        public Context() : base("desafio") {}
        public DbSet<Anuncio> Anuncio { get; set; }
    }
}
