using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmAutenticacao : Form
    {
        Usuario usuario = new Usuario();
        UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

        public FrmAutenticacao()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (usuarioNegocios.Login(txbUsuario.Text,txbSenha.Text))
            {
                if (rdoSessao.Checked)
                {
                    Form sessao = new FrmSessao();
                    this.Hide();
                    sessao.Show();
                }
                if (rdoCadastrar.Checked)
                {
                    Form cadastro = new FrmMenu();
                    this.Hide();
                    cadastro.Show();
                }
            }
        }
    }
}
