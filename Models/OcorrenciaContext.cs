using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HelpDesk.Models
{
    public class OcorrenciaContext
    {
        public string ConnectionString { get; set;}

        public OcorrenciaContext(string connectionString){
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection(){
            return new MySqlConnection(ConnectionString);
        }

        public void addOcorrencia(OcorrenciaModel ocorrencia){
            
             using (MySqlConnection con = GetConnection()){
                con.Open();
                string mysql = $@"INSERT INTO OCORRENCIA (NUMERO,DATAREGISTRO,DATAVENCIMENTO,DESCRICAO) VALUES ({ocorrencia.gerarNumero()}, '{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}' ,'{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")}','{ocorrencia.Descrição}');";

                MySqlCommand cmd = new MySqlCommand(mysql, con);
                
                cmd.ExecuteNonQuery();
            }
        }
    }
}