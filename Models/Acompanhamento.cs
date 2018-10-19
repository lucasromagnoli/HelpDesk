namespace HelpDesk.Models
{
    public class Acompanhamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Usuario Usuario { get; set; }

        public override string  ToString(){
            return "";
        }
    }
}