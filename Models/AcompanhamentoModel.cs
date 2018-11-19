using System;

namespace HelpDesk.Models
{
    public class AcompanhamentoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public UsuarioModel Usuario { get; set; }

        public AcompanhamentoModel(){
            this.DataAbertura = DateTime.Now;
        }
        public override string  ToString(){
            return $"Aberta por: {Usuario.Nome} ({Usuario.Login}) em {DataAbertura} \n {Descricao} \n\n";
        }
    }
}