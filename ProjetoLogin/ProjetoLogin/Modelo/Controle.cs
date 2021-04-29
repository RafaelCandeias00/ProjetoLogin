using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo {
    public class Controle {
        public bool existe;
        public string mensagem = "";
        public bool Acessar(string login, string senha) {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            existe = loginDao.VerificarLogin(login, senha);
            if (!loginDao.mensagem.Equals("")){
                this.mensagem = loginDao.mensagem;
            }
            return existe;
        }

        /*internal void Cadastrar(object emai) {
            throw new NotImplementedException();
        }*/

        public string Cadastrar(string email, string senha, string confirmarSenha) {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.Cadastrar(email, senha, confirmarSenha);
            if (loginDao.existe) { // mensagem de cadastro com sucesso
                this.existe = true;
            }
            return mensagem;
        }

        /*internal void acessar() {
            throw new NotImplementedException();
        }*/
    }
}
