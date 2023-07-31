﻿using Microsoft.AspNetCore.Mvc;
using teste_tecnico_fadami.Helper;
using teste_tecnico_fadami.Models;
using teste_tecnico_fadami.Repository;

namespace teste_tecnico_fadami.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ISessao _sessao;
        public UsuarioController(IUsuarioRepository usuarioRepository,
                                 ISessao sessao)
        {
            _usuarioRepository = usuarioRepository;
            _sessao = sessao;
        }
        public IActionResult Login()
        {
            // Se o usuario estiver logado, redirecionar para Consultar

            if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Consultar");

            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoDoUsuario();
            return RedirectToAction("Login");
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
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepository.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso";
                    return RedirectToAction("Consultar");
                }

                return View(usuario);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não foi possível cadastrar! Detalhe do erro: {erro.Message}";
                return RedirectToAction("Consultar");
            }
            
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepository.BuscarPorLogin(loginModel.LOGIN);

                    if (usuario != null)
                    {
                        if(usuario.SenhaValida(loginModel.SENHA))
                        {
                            _sessao.CriarSessaoDoUsuario(usuario);
                            return RedirectToAction("Consultar");
                        }



                        TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Tente novamente!";
                    }
                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Tente novamente!";
                    
                }
               

                return View("Login");
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = $"Ops, não foi possível logar! Detalhe do erro: {erro.Message}";
                return RedirectToAction("Login");
            }
        }

    }
}
