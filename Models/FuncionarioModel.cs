using System;

namespace HelpDesk.Models
{
    public class FuncionarioModel
    {
        public string FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public SetorModel Setor { get; set; }
        public DateTime DataDeNascimento { get; set; }

    }
}