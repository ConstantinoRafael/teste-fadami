namespace teste_tecnico_fadami.Models
{
    public class UsuarioModel
    {
        public int Id {get; set; }
        public string NOME { get; set; }
        public string LOGIN { get; set; }
        public string CPF { get; set; }
        public string SENHA { get; set; }
        public string ULTIMO_ACESSO { get; set; }
        public int QTD_ERRO_LOGIN { get; set; }
        public string BL_ATIVO { get; set; }

    }
}
