using teste_tecnico_fadami.Models;

namespace teste_tecnico_fadami.Repository
{
    public interface IUsuarioRepository
    {
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
    }
}
