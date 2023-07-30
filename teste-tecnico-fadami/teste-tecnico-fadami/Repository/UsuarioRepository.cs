
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
        public UsuarioModel BuscarPorId(int id)
        {
            return _contexto.Usuarios.FirstOrDefault(x => x.Id == id);
        }
        public List<UsuarioModel> BuscarTodos()
        {
            return _contexto.Usuarios.ToList();
        }
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            usuario.ULTIMO_ACESSO = DateTime.Now;
            usuario.QTD_ERRO_LOGIN = 0;
            usuario.BL_ATIVO = false;
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
            return usuario;
        }
        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = BuscarPorId(usuario.Id);

            if (usuarioDB == null) throw new Exception("Houve um erro na atualização do usuário");

            usuarioDB.ULTIMO_ACESSO = usuario.ULTIMO_ACESSO;
            usuarioDB.QTD_ERRO_LOGIN = usuario.QTD_ERRO_LOGIN;
            usuarioDB.BL_ATIVO = usuario.BL_ATIVO;

            _contexto.Usuarios.Update(usuarioDB);
            _contexto.SaveChanges();

            return usuarioDB;

        }
    }
}
