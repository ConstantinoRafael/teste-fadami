using Microsoft.EntityFrameworkCore;
using teste_tecnico_fadami.Models;

namespace teste_tecnico_fadami.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
