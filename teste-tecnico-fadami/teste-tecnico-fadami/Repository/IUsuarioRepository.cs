using teste_tecnico_fadami.Models;

namespace teste_tecnico_fadami.Repository
{
    public interface IUsuarioRepository
    {
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel usuario);   
    }
}
