
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
        public UsuarioModel BuscarPorLogin(string login)
        {
            return _contexto.Usuarios.FirstOrDefault(x => x.LOGIN.ToUpper() == login.ToUpper());
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

        public UsuarioModel AtualizarUtlimoAcesso(UsuarioModel usuario, DateTime date)
        {
            UsuarioModel usuarioDB = BuscarPorId(usuario.Id);

            if (usuarioDB == null) throw new Exception("Houve um erro na atualização do usuário");

            usuarioDB.ULTIMO_ACESSO = date;

            _contexto.Usuarios.Update(usuarioDB);
            _contexto.SaveChanges();

            return usuarioDB;
        }
        public UsuarioModel AtualizarQtdErr(UsuarioModel usuario, int qtd_err)
        {
            UsuarioModel usuarioDB = BuscarPorId(usuario.Id);

            if (usuarioDB == null) throw new Exception("Houve um erro na atualização do usuário");

            usuarioDB.QTD_ERRO_LOGIN = qtd_err;
            
            _contexto.Usuarios.Update(usuarioDB);
            _contexto.SaveChanges();

            return usuarioDB;

        }

       
        public UsuarioModel AtualizarBl(UsuarioModel usuario, bool bl)
        {
            UsuarioModel usuarioDB = BuscarPorId(usuario.Id);

            if (usuarioDB == null) throw new Exception("Houve um erro na atualização do usuário");

            usuarioDB.BL_ATIVO = bl;

            _contexto.Usuarios.Update(usuarioDB);
            _contexto.SaveChanges();

            return usuarioDB;
        }

        
    }
}
