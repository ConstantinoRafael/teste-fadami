using Microsoft.AspNetCore.Mvc;
using teste_tecnico_fadami.Models;
using teste_tecnico_fadami.Repository;

namespace teste_tecnico_fadami.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            List<UsuarioModel> usuarios = _usuarioRepository.BuscarTodos();
            return View(usuarios);
        }

        [HttpPost]
        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            _usuarioRepository.Adicionar(usuario);
            return RedirectToAction("Consultar");
        }
    }
}
