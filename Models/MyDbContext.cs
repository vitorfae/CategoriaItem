using Microsoft.EntityFrameworkCore;

namespace categoriaItem.Models
{
    // A classe de contexto de banco de dados
    //ou DbContext é responsável por
    //mapear as classes que serão atreadas
    //às tabelas do banco de dados
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        // Nesta sessão especificamos as
        // classes do Models que serão espelhadas
        // em tabelas do BD

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Item> Itens { get; set; }
    }
}
