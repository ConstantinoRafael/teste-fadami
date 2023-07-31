using System.ComponentModel.DataAnnotations;

namespace teste_tecnico_fadami.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite seu login")]
        [MaxLength(20)]
        public string LOGIN { get; set; }
       
        [Required(ErrorMessage = "Digite sua senha")]
        [MinLength(7)]
        [MaxLength(20)]
        public string SENHA { get; set; }
    }
}
