
using teste_tecnico_fadami.Data;
using teste_tecnico_fadami.Models;

namespace teste_tecnico_fadami.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Contexto _contexto;

        public UsuarioRepository(Contexto contexto) {
            _contexto = contexto;
        }  
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();

            return usuario;
        }
        public List<UsuarioModel> BuscarTodos()
        {
            return _contexto.Usuarios.ToList();
        }
    }
}
