using System.ComponentModel.DataAnnotations;

namespace teste_tecnico_fadami.Models
{
    public class UsuarioModel
    {
        public int Id {get; set; }
        [Required(ErrorMessage = "Digite seu nome")]
        [MaxLength(50)]
        public string NOME { get; set; }
        [Required(ErrorMessage = "Digite seu login")]
        [MaxLength(20)]
        public string LOGIN { get; set; }
        [Required(ErrorMessage = "Digite seu cpf")]
        [MaxLength(14)]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Digite sua senha")]
        [MinLength(7)]
        [MaxLength(20)]
        public string SENHA { get; set; }
        [Compare("SENHA", ErrorMessage ="Deve ser igual à senha")]
        public string CONFIRMA_SENHA { get; set; }
        public DateTime? ULTIMO_ACESSO { get; set; }
        public int? QTD_ERRO_LOGIN { get; set; }
        public bool? BL_ATIVO { get; set; }

        public bool SenhaValida(string senha)
        {
            return SENHA == senha;
        }

    }
}
