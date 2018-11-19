namespace HelpDesk.Models
{
    public class UsuarioModel : FuncionarioModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string NivelAtendimento { get; set; }
    }
}