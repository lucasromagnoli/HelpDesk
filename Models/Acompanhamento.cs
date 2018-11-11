using System;

namespace HelpDesk.Models
{
    public class Acompanhamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public Usuario Usuario { get; set; }

        public Acompanhamento(){
            this.DataAbertura = DateTime.Now;
        }
        public override string  ToString(){
            return $"Aberta por: {Usuario.Nome} ({Usuario.Login}) em {DataAbertura} \n {Descricao} \n\n";
        }
    }
}