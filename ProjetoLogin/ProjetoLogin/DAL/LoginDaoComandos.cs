using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.DAL {
    class LoginDaoComandos {
        public bool existe;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dataReadr;
        public bool VerificarLogin(string login, string senha) {
            //procurando login e senha no banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try {
                cmd.Connection = con.conectar();
                dataReadr = cmd.ExecuteReader();
                if (dataReadr.HasRows) { // se foi encontrado
                    existe = true;
                }
                con.Desconectar();
                dataReadr.Close();
            } catch (SqlException){
                this.mensagem = "Erro com Banco de dados!";
            }

            return existe;
        }

        public string Cadastrar(string email, string senha, string confirmarSenha) {
            existe = false;
            //comandos para inserir
            if (senha.Equals(confirmarSenha)) {
                cmd.CommandText = "insert into logins values (@e,@s)";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);
                try {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastro feito!";
                    existe = true;
                } catch (SqlException) {
                    this.mensagem = "Erro com banco de dados";
                }
            } else {
                this.mensagem = "Senhas não correspondem!";
            }
            
            return mensagem;
        }
    }
}
