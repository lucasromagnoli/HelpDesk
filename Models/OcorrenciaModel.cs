using System;
using System.Collections.Generic;

namespace HelpDesk.Models
{
    public enum Status : int {Pendente = 0, Cancelada = 1, Resolvida = 2};
    
    public class OcorrenciaModel
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public DateTime DataDeVencimento { get; set; }
        public DateTime DataDeEncerramento { get; set; }
        public string Descricao { get; set; }
        public Status Status { get; set; }
        public Usuario Usuario { get; set; }
        public Setor Setor { get; set; }
        public string Nivel { get; set; }
        public string Categoria { get; set; }
        public List<Acompanhamento> Acompanhamentos = new List<Acompanhamento>();

        public OcorrenciaModel() {
            this.Numero = gerarNumero();
            this.Id = 0;
            this.Setor = new Setor () {Id = 1, Nome = "Tecnologia da informação"};
            this.DataDeRegistro = DateTime.Now;
            this.DataDeVencimento = this.DataDeRegistro.AddDays(new System.Random().Next(1,6)).AddMinutes(new System.Random().Next(35,333));
            this.Nivel = "1";
        }
        // Metodos
        public string gerarNumero(){
            string numero = (DateTime.Now.Day.ToString()+DateTime.Now.Year.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString()+DateTime.Now.Second.ToString()+DateTime.Now.Month.ToString()+DateTime.Now.Millisecond.ToString());
            return numero;
        }
    }
}