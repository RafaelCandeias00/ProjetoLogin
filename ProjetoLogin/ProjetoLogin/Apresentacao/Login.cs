using ProjetoLogin.Apresentacao;
using ProjetoLogin.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLogin {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void cadastreseBTN_Click(object sender, EventArgs e) {
            CadastreSe cad = new CadastreSe();
            cad.Show();
        }

        private void sairBTN_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void entrarBTN_Click(object sender, EventArgs e) {
            Controle controle = new Controle();
            controle.Acessar(loginTXB.Text, senhaTXB.Text);
            if (controle.mensagem.Equals("")) {
                if (controle.existe) {
                    MessageBox.Show("Login efetuado", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bemVindo = new BemVindo();
                    bemVindo.Show();
                } else {
                    MessageBox.Show("Login não foi efetuado, verifique login e senha", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show(controle.mensagem);
            }
            
        }
    }
}
