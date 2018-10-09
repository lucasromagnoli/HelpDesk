namespace HelpDesk.Models
{
    public class Usuario : Funcionário
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string NivelAtendimento { get; set; }
    }
}