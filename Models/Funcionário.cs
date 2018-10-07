using System;

namespace HelpDesk.Models
{
    public class Funcionário
    {
        public string FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public Setor Setor { get; set; }
        public DateTime DataDeNascimento { get; set; }

    }
}