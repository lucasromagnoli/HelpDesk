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

        public List<OcorrenciaModel> listaOcorrencia(Usuario usuario){
            List<OcorrenciaModel> list = new List<OcorrenciaModel>();
            using (MySqlConnection con = GetConnection()){
                con.Open();
                string sql = "SELECT ID_OCORRENCIA, OC.NUMERO_OCORRENCIA, OC.DATAREGISTRO_OCORRENCIA, OC.DATAVENCIMENTO_OCORRENCIA, OC.DATAENCERRAMENTO_OCORRENCIA, OC.STATUS_OCORRENCIA, OC.DESCRICAO_OCORRENCIA, SE.ID_SETOR, SE.NOME_SETOR FROM OCORRENCIA OC INNER JOIN SETOR SE ON OC.ID_SETOR_OCORRENCIA = SE.ID_SETOR WHERE OC.ID_USUARIO_OCORRENCIA = ?idusuario;";  
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?idusuario", usuario.Id);
                using (MySqlDataReader reader = cmd.ExecuteReader()){
                    while (reader.Read()){
                        list.Add(new OcorrenciaModel(){
                            Id = reader.GetInt32("id_ocorrencia"),
                            Numero = reader.GetString("numero_ocorrencia"),
                            DataDeRegistro = reader.GetDateTime("dataregistro_ocorrencia"),
                            DataDeVencimento = reader.GetDateTime("datavencimento_ocorrencia"),
                            DataDeEncerramento = reader.GetDateTime("dataencerramento_ocorrencia"),
                            Descrição = reader.GetString("descricao_ocorrencia"),
                            Status = (Status) reader.GetInt16("status_ocorrencia"),
                            Setor = new Setor(){Id = reader.GetInt32("id_setor"), Nome = reader.GetString("nome_setor")},
                            Usuario = usuario
                        });
                    }
                }
                con.Close();
            }
            return list;
        }

        public OcorrenciaModel listaOcorrencia(string numero){
            OcorrenciaModel ocorrenciaModel = new OcorrenciaModel();
            using (MySqlConnection con = GetConnection()){
                con.Open();
                string sql = "SELECT OC.ID_OCORRENCIA, OC.NUMERO_OCORRENCIA, OC.DATAREGISTRO_OCORRENCIA, OC.DATAVENCIMENTO_OCORRENCIA, OC.DATAENCERRAMENTO_OCORRENCIA, OC.STATUS_OCORRENCIA, OC.DESCRICAO_OCORRENCIA, SE.ID_SETOR, SE.NOME_SETOR, US.ID_USUARIO, US.LOGIN_USUARIO FROM OCORRENCIA OC INNER JOIN SETOR SE ON OC.ID_SETOR_OCORRENCIA = SE.ID_SETOR INNER JOIN USUARIO US ON OC.ID_USUARIO_OCORRENCIA = US.ID_USUARIO WHERE OC.NUMERO_OCORRENCIA = ?numero;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?numero", numero);
                using (MySqlDataReader reader = cmd.ExecuteReader()){
                    while (reader.Read()){
                        ocorrenciaModel.Id = reader.GetInt32("id_ocorrencia");
                        ocorrenciaModel.Numero = reader.GetString("numero_ocorrencia");
                        ocorrenciaModel.DataDeRegistro = reader.GetDateTime("dataregistro_ocorrencia");
                        ocorrenciaModel.DataDeVencimento = reader.GetDateTime("datavencimento_ocorrencia");
                        ocorrenciaModel.DataDeEncerramento = reader.GetDateTime("dataencerramento_ocorrencia");
                        ocorrenciaModel.Descrição = reader.GetString("descricao_ocorrencia");
                        ocorrenciaModel.Status = (Status) reader.GetInt16("status_ocorrencia");
                        ocorrenciaModel.Setor = new Setor(){Id = reader.GetInt32("id_setor"), Nome = reader.GetString("nome_setor")};
                        ocorrenciaModel.Usuario = new Usuario(){Id = reader.GetInt32("id_usuario"), Login = reader.GetString("login_usuario")};  
                    }
                } 
                con.Close();
            }
            return ocorrenciaModel;
        }
        private MySqlConnection GetConnection(){
            return new MySqlConnection(ConnectionString);
        }

        public void adicionaOcorrencia(OcorrenciaModel ocorrencia){
             using (MySqlConnection con = GetConnection()){
                con.Open();
                string query = "INSERT INTO OCORRENCIA (NUMERO_OCORRENCIA, DATAREGISTRO_OCORRENCIA, DATAVENCIMENTO_OCORRENCIA, STATUS_OCORRENCIA, DESCRICAO_OCORRENCIA, ID_SETOR_OCORRENCIA, ID_USUARIO_OCORRENCIA) VALUES (?NUMERO_OCORRENCIA, ?DATAREGISTRO_OCORRENCIA,?DATAVENCIMENTO_OCORRENCIA, ?STATUS_OCORRENCIA, ?DESCRICAO_OCORRENCIA, ?ID_SETOR_OCORRENCIA, ?ID_USUARIO_OCORRENCIA);";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?NUMERO_OCORRENCIA", ocorrencia.Numero);
                cmd.Parameters.AddWithValue("?DATAREGISTRO_OCORRENCIA", ocorrencia.DataDeRegistro.ToString("yyyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("?DATAVENCIMENTO_OCORRENCIA", ocorrencia.DataDeVencimento.ToString("yyyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("?STATUS_OCORRENCIA", ocorrencia.Status.GetHashCode().ToString());
                cmd.Parameters.AddWithValue("?DESCRICAO_OCORRENCIA", ocorrencia.Descrição);
                cmd.Parameters.AddWithValue("?ID_SETOR_OCORRENCIA", ocorrencia.Setor.Id);
                cmd.Parameters.AddWithValue("?ID_USUARIO_OCORRENCIA", ocorrencia.Usuario.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}