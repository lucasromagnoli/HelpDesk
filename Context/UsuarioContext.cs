using System;
using HelpDesk.Models;
using MySql.Data.MySqlClient;

namespace HelpDesk.Context
{
    public class UsuarioContext
    {
        public string ConnectionString { get; set;}
        public UsuarioContext (string connectionString) {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection(){
            return new MySqlConnection(ConnectionString);
        }

        public Usuario GetUsuario(string login){
            Usuario usuario = new Usuario();
            using (MySqlConnection con = GetConnection()){
                con.Open();
                string sql = "SELECT US.ID_USUARIO, US.LOGIN_USUARIO, US.NIVELATENDIMENTO_USUARIO, FU.NOME_FUNCIONARIO, FU.DATANASCIMENTO_FUNCIONARIO, FU.CPF_FUNCIONARIO, FU.RG_FUNCIONARIO, SE.ID_SETOR, SE.NOME_SETOR FROM USUARIO US INNER JOIN FUNCIONARIO FU ON US.ID_FUNCIONARIO_USUARIO = FU.ID_FUNCIONARIO INNER JOIN SETOR SE ON FU.ID_SETOR_FUNCIONARIO = SE.ID_SETOR WHERE US.LOGIN_USUARIO = ?login;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?login", login);
                using (MySqlDataReader reader = cmd.ExecuteReader()){
                    while (reader.Read()){
                        usuario.Id = reader.GetInt32("id_usuario");
                        usuario.Login = reader.GetString("login_usuario");
                        usuario.NivelAtendimento = reader.GetString("nivelatendimento_usuario"); 
                        usuario.Nome = reader.GetString("nome_funcionario");
                        usuario.Cpf = reader.GetString("cpf_funcionario");
                        usuario.Rg = reader.GetString("rg_funcionario");
                        usuario.DataDeNascimento = reader.GetDateTime("datanascimento_funcionario");
                        usuario.Setor = new Setor(){Id = reader.GetInt32("id_setor"), Nome = reader.GetString("nome_setor")};
                    }
                } 
                con.Close();
            }
            return usuario;
        } 

        public Usuario GetUsuario(int id){
            
            Usuario usuario = new Usuario();
            using (MySqlConnection con = GetConnection()){
                con.Open();
                string sql = "SELECT US.ID_USUARIO, US.LOGIN_USUARIO, US.NIVELATENDIMENTO_USUARIO, FU.NOME_FUNCIONARIO, FU.DATANASCIMENTO_FUNCIONARIO, FU.CPF_FUNCIONARIO, FU.RG_FUNCIONARIO, SE.ID_SETOR, SE.NOME_SETOR FROM USUARIO US INNER JOIN FUNCIONARIO FU ON US.ID_FUNCIONARIO_USUARIO = FU.ID_FUNCIONARIO INNER JOIN SETOR SE ON FU.ID_SETOR_FUNCIONARIO = SE.ID_SETOR WHERE US.ID_USUARIO = ?id;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("?id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader()){
                    while (reader.Read()){
                        usuario.Id = reader.GetInt32("id_usuario");
                        usuario.Login = reader.GetString("login_usuario");
                        usuario.NivelAtendimento = reader.GetString("nivelatendimento_usuario"); 
                        usuario.Nome = reader.GetString("nome_funcionario");
                        usuario.Cpf = reader.GetString("cpf_funcionario");
                        usuario.Rg = reader.GetString("rg_funcionario");
                        usuario.DataDeNascimento = reader.GetDateTime("datanascimento_funcionario");
                        usuario.Setor = new Setor(){Id = reader.GetInt32("id_setor"), Nome = reader.GetString("nome_setor")};
                    }
                } 
                con.Close();
            }
            return usuario;
        } 

        public bool AutenticaUsuario(string login, string senha){
            bool autenticado = false;
            using (MySqlConnection con = GetConnection()){
                con.Open();
                string sql = "SELECT COUNT(*) FROM USUARIO WHERE LOGIN_USUARIO = ?login  AND SENHA_USUARIO = BINARY ?senha;";
                using (MySqlCommand cmd = new MySqlCommand(sql, con)) {
                    cmd.Parameters.AddWithValue("?login", login);
                    cmd.Parameters.AddWithValue("?senha", senha);

                    autenticado = Convert.ToBoolean(cmd.ExecuteScalar());
                }
            }
            return autenticado;
        }
    }


}