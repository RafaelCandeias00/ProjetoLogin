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

namespace ProjetoLogin.Apresentacao {
    public partial class CadastreSe : Form {
        public CadastreSe() {
            InitializeComponent();
        }

        private void cadastrarBTN_Click(object sender, EventArgs e) {
            Controle controle = new Controle();
            String mensagem = controle.Cadastrar(loginTXB.Text, senhaTXB.Text, confirmarSenhaTXB.Text);
            if (controle.existe) { //mensagem de sucesso
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show(controle.mensagem); // mensagem de erro
            }
        }
    }
}
