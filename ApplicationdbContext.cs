using Microsoft.EntityFrameworkCore;
using Web_Api_.NET.Controllers.Entidades;

namespace Web_Api_.NET
{
    public class ApplicationdbContext: DbContext
    {
        public ApplicationdbContext(DbContextOptions ops): base(ops)
        { 
        
        }

        public DbSet<Autor> Autores { get; set; }
    }
}
