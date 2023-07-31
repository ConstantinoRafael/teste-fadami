using teste_tecnico_fadami.Models;

namespace teste_tecnico_fadami.Repository
{
    public interface IUsuarioRepository
    {
        UsuarioModel BuscarPorLogin(string login);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel AtualizarUtlimoAcesso(UsuarioModel usuario, DateTime date);
        UsuarioModel AtualizarQtdErr(UsuarioModel usuario, int err);
        UsuarioModel AtualizarBl(UsuarioModel usuario, bool bl);
    }
}
