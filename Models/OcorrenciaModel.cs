using System;
using System.Collections.Generic;

namespace HelpDesk.Models
{
    public class OcorrenciaModel
    {
        public string Numero { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public DateTime DataDeVencimento { get; set; }
        public DateTime DataDeEncerramento { get; set; }
        public string Descrição { get; set; }
        public enum Status : int {Pendente = 0, Cancelada = 1, Resolvida = 2};
        public List<Acompanhamento> Acompanhamentos = new List<Acompanhamento>();

        // Metodos
        public string gerarNumero(){
            return  (DateTime.Now.Millisecond.ToString()+DateTime.Now.Day.ToString()+DateTime.Now.Year.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString()+DateTime.Now.Second.ToString()+DateTime.Now.Month.ToString());
        }
        
    }
}