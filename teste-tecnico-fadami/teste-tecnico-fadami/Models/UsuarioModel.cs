using System.ComponentModel.DataAnnotations;

namespace teste_tecnico_fadami.Models
{
    public class UsuarioModel
    {
        public int Id {get; set; }
        [Required]
        [MaxLength(50)]
        public string NOME { get; set; }
        [Required]
        [MaxLength(20)]
        public string LOGIN { get; set; }
        [Required]
        [MaxLength(14)]
        public string CPF { get; set; }
        [Required]
        [MinLength(7)]
        [MaxLength(20)]
        public string SENHA { get; set; }
        public DateTime? ULTIMO_ACESSO { get; set; }
        public int? QTD_ERRO_LOGIN { get; set; }
        public bool? BL_ATIVO { get; set; }

    }
}
