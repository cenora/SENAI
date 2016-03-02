using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Não esquecer
using BancoTeste.Properties; //Não esquecer

//http://www.devmedia.com.br/utilizando-stored-procedures-com-transaction-em-mysql-e-c/15906
//http://www.macoratti.net/12/02/adn_usp1.htm

namespace BancoTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Control controle = new Control();
        DTOPessoa pessoa = new DTOPessoa();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pessoa.Nome = txtNome.Text;
            pessoa.Endereco = txtEndereco.Text;
            string retorno = controle.Inserir(pessoa).ToString();
                MessageBox.Show(retorno);
        }

    }
}
